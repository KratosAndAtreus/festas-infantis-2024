using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloItens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        private RepositorioTema repositorioTema;
        private TabelaTemaControl tabelaTema;

        public ControladorTema(RepositorioTema repositorio)
        {
            this.repositorioTema = repositorio;
        }
        public override string TipoCadastro { get { return "Temas"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo tema"; } }

        public override string ToolTipEditar { get { return "Editar um tema existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um tema existente"; } }

        public override void Adicionar()
        {
            TelaTemaForm telaTema = new TelaTemaForm();

            DialogResult resultado = telaTema.ShowDialog();

            //fazer o if em direção ao erro(ou seja em caso de erro)
            if (resultado != DialogResult.OK)
                return;

            Tema novoTema = telaTema.Tema;


            repositorioTema.Cadastrar(novoTema);

            CarregarItens();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro\"{novoTema.Titulo}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaTemaForm telaTema = new TelaTemaForm();

            int idSelecionado = tabelaTema.ObterRegistroSelecionado();

            Tema temaSelecionado =
                repositorioTema.SelecionarPorId(idSelecionado);

            if (temaSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaTema.Tema = temaSelecionado;

            DialogResult resultado = telaTema.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Tema temaEditado = telaTema.Tema;

            repositorioTema.Editar(temaSelecionado.Id, temaEditado);

            CarregarItens();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro\"{temaEditado.Titulo}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaTema.ObterRegistroSelecionado();

            Tema temaSelecionado =
                repositorioTema.SelecionarPorId(idSelecionado);

            if (temaSelecionado == null)
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
                $"Você deseja realmente excluir o registro \"{temaSelecionado.Titulo}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioTema.Excluir(temaSelecionado.Id);

            CarregarItens();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro\"{temaSelecionado.Titulo}\" foi excluído com sucesso!");
        }

        private void CarregarItens()
        {
            List<Tema> temas = repositorioTema.SelecionarTodos();

            tabelaTema.AtualizarRegistros(temas);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaTema == null)
                tabelaTema = new TabelaTemaControl();

            CarregarItens();

            return tabelaTema;
        }
    }
}
