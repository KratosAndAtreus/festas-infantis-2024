using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloItens;
using FestasInfantis.WinApp.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloAlugueis
{
    internal class ControladorAluguel : ControladorBase
    {
        private RepositorioAluguel repositorioAluguel;
        private TabelaAluguelControl tabelaAluguel;

        private RepositorioTema repositorioTema;
        private RepositorioCliente repositorioCliente;

        public ControladorAluguel(RepositorioAluguel repositorio, RepositorioTema repositorioTema, RepositorioCliente repositorioCliente)
        {
            this.repositorioAluguel = repositorio;
            this.repositorioTema = repositorioTema;
            this.repositorioCliente = repositorioCliente;
        }

        public override string TipoCadastro { get { return "Alugueis"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo aluguel"; } }

        public override string ToolTipEditar { get { return "Editar um aluguel existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um aluguel existente"; } }

        public override void Adicionar()
        {
            TelaAluguelForm telaAluguel = new TelaAluguelForm();

            var clientesCadastrados = repositorioCliente.SelecionarTodos(); 
            telaAluguel.CarregarClientes(clientesCadastrados);

            var temasCadastrados = repositorioTema.SelecionarTodos();
            telaAluguel.CarregarTemas(temasCadastrados);

            DialogResult resultado = telaAluguel.ShowDialog();

            //fazer o if em direção ao erro(ou seja em caso de erro)
            if (resultado != DialogResult.OK)
                return;
            Aluguel novoAluguel = telaAluguel.Aluguel;


            repositorioAluguel.Cadastrar(novoAluguel);

            CarregarItens();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro\"{novoAluguel.Tema}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaAluguelForm telaAluguel = new TelaAluguelForm();

            int idSelecionado = tabelaAluguel.ObterRegistroSelecionado();

            var clientesCadastrados = repositorioCliente.SelecionarTodos();
            telaAluguel.CarregarClientes(clientesCadastrados);

            var temasCadastrados = repositorioTema.SelecionarTodos();
            telaAluguel.CarregarTemas(temasCadastrados);

            Aluguel aluguelSelecionado =
                repositorioAluguel.SelecionarPorId(idSelecionado);

            if (aluguelSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaAluguel.Aluguel = aluguelSelecionado;

            DialogResult resultado = telaAluguel.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Aluguel aluguelEditado = telaAluguel.Aluguel;

            repositorioAluguel.Editar(aluguelSelecionado.Id, aluguelEditado);

            CarregarItens();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro\"{aluguelEditado.Tema}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaAluguel.ObterRegistroSelecionado();

            Aluguel aluguelSelecionado =
                repositorioAluguel.SelecionarPorId(idSelecionado);

            if (aluguelSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{aluguelSelecionado.Tema}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioAluguel.Excluir(aluguelSelecionado.Id);

            CarregarItens();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro\"{aluguelSelecionado.Tema}\" foi excluído com sucesso!");
        }

        private void CarregarItens()
        {
            List<Aluguel> alugueis = repositorioAluguel.SelecionarTodos();

            tabelaAluguel.AtualizarRegistros(alugueis);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaAluguel == null)
                tabelaAluguel = new TabelaAluguelControl();

            CarregarItens();

            return tabelaAluguel;
        }
    }
}
