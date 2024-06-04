using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class TabelaClientesControl : UserControl
    {
        public TabelaClientesControl()
        {
            InitializeComponent();

            clienteGridView.Columns.AddRange(GerarColunas());

            clienteGridView.ConfigurarGridSomenteLeitura();
            clienteGridView.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Cliente> clientes)
        {
            clienteGridView.Rows.Clear();

            foreach (Cliente cliente in clientes)
            {
                clienteGridView.Rows.Add(cliente.Id,cliente.Nome,cliente.Telefone,cliente.CPF);
            }
        }

        public int ObterRegistroSelecionado()
        {
            return clienteGridView.SelecionarId();
        }

        private static DataGridViewColumn[] GerarColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "id", HeaderText = "ID"},
                new DataGridViewTextBoxColumn { DataPropertyName = "nome", HeaderText = "Nome"},
                new DataGridViewTextBoxColumn { DataPropertyName = "telefone", HeaderText = "Telefone"},
                new DataGridViewTextBoxColumn {DataPropertyName = "cpf", HeaderText = "CPF"},
            };
        }
    }
}
