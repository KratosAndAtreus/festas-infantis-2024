using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloAlugueis
{
    public partial class TelaAluguelForm : Form
    {

        private Aluguel aluguel;

        public Aluguel Aluguel
        {
            set
            {
                txtId.Text = value.Id.ToString();
                cmbClientes.SelectedItem = value.Cliente;
                cmbTema.SelectedItem = value.Tema;
                cmbPorcentagemEntrada.SelectedItem = value.PorcentagemEntrada;
                txtPorcentagemDesconto.Text = value.PorcentagemDesconto.ToString();


            }
            get
            {
                return aluguel;
            }
        }

        public TelaAluguelForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }
    }
}
