using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.Compartilhado;
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
        private RepositorioItem repositorioItem;

        public ControladorTema(RepositorioTema repositorio,RepositorioItem repositorioItem)
        {
            this.repositorioTema = repositorio;
            this.repositorioItem = repositorioItem;
        }
        public override string TipoCadastro { get { return "Temas"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo tema"; } }

        public override string ToolTipEditar { get { return "Editar um tema existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um tema existente"; } }

        public override void Adicionar()
        {
            TelaTemaForm telaTema = new TelaTemaForm();

            List<Item> itensDisponiveis = repositorioItem.SelecionarItensDisponiveis();

            telaTema.CarregarItens(itensDisponiveis);

            DialogResult resultado = telaTema.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Tema novoTema = telaTema.Tema;


            repositorioTema.Cadastrar(novoTema);

            repositorioTema.AdicionarItens(novoTema, telaTema.itensMarcados);

            CarregarTemas();

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


            List<Item> itensDisponiveis = repositorioItem.SelecionarItensDisponiveis(temaSelecionado);

            telaTema.CarregarItens(itensDisponiveis);

            telaTema.Tema = temaSelecionado;

            DialogResult resultado = telaTema.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Tema temaEditado = telaTema.Tema;

            repositorioTema.Editar(temaSelecionado.Id, temaEditado);

            repositorioTema.AdicionarItens(temaSelecionado,temaEditado, telaTema.itensMarcados, telaTema.itensDesmarcados);

            CarregarTemas();

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

            CarregarTemas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro\"{temaSelecionado.Titulo}\" foi excluído com sucesso!");
        }

        private void CarregarTemas()
        {
            List<Tema> temas = repositorioTema.SelecionarTodos();

            tabelaTema.AtualizarRegistros(temas);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaTema == null)
                tabelaTema = new TabelaTemaControl();

            CarregarTemas();

            return tabelaTema;
        }

    }
}
