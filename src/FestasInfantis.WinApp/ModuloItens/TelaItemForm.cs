using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloItens
{
    public partial class TelaItemForm : Form
    {
        private Item item;

        public Item Item
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtDescricao.Text = value.Descricao;
                numValor.Value= value.Valor;
            }
            get
            {
                return item;
            }
        }
        public TelaItemForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string descrição = txtDescricao.Text;
            decimal valor = numValor.Value;

            item = new Item(descrição, valor);

            List<string> erros = item.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
