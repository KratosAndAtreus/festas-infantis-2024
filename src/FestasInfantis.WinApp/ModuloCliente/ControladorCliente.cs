using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        private RepositorioCliente repositorioCliente;
        private TabelaClientesControl tabelaClientes;

        public ControladorCliente (RepositorioCliente repositorio)
        {
            repositorioCliente = repositorio;
        }

        public override string TipoCadastro { get { return "Clientes"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo cliente"; } }

        public override string ToolTipEditar { get { return "Editar um novo cliente"; } }

        public override string ToolTipExcluir { get { return "Excluir um novo cliente"; } }

        public override void Adicionar()
        {
            TelaClienteForm telaCliente = new TelaClienteForm();

            DialogResult resultado = telaCliente.ShowDialog();

            if(resultado != DialogResult.OK)
            {
                return;
            }

            Cliente novoCliente = telaCliente.Cliente;

            repositorioCliente.Cadastrar(novoCliente);

            CarregarCliente();


            TelaPrincipalForm
                .Instancia
                .AtualizarRodape("Cliente ADICIONADO com sucesso!");
        }

        public override void Editar()
        {
            TelaClienteForm telaCliente = new TelaClienteForm();

            int idSelecionado = tabelaClientes.ObterRegistroSelecionado();

            if (idSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um registro",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                return;
            }

            telaCliente.Cliente = repositorioCliente.SelecionarPorId(idSelecionado);

            DialogResult resultado = telaCliente.ShowDialog();

            if(resultado != DialogResult.OK )
            {
                return;
            }

            Cliente clienteEditado = telaCliente.Cliente;

            repositorioCliente.Editar(idSelecionado, clienteEditado);

            CarregarCliente();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"Cadastro \"{idSelecionado}\" , \"{clienteEditado.Nome}\" EDITADO com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaClientes.ObterRegistroSelecionado();

            if (idSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um registro",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                return;
            }

            DialogResult resposta = MessageBox.Show(
              $"Você realmente deseja excluir \"{idSelecionado}\"?  ",
              "Confirmar Exclusão",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning
              );

            if (resposta != DialogResult.Yes)
                return;

            repositorioCliente.Excluir(idSelecionado);

            CarregarCliente();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"Cadastro EXCLUIDO com sucesso!");
        }

        private void CarregarCliente()
        {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();

            tabelaClientes.AtualizarRegistros(clientes);
        }

        public override UserControl ObterListagem()
        {
            if(tabelaClientes == null)
                tabelaClientes = new TabelaClientesControl();

            CarregarCliente();
            return tabelaClientes;
        }
    }
}
