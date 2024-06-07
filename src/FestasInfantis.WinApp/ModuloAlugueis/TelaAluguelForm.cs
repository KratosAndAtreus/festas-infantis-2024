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
                cmbSinal.SelectedItem = value.Sinal;

                dtFesta.Value = value.Festa.Data;
                mskHoraInicio.Text = value.Festa.HorarioInicio.ToString();
                mskHoraTermino.Text = value.Festa.HorarioTermino.ToString();

                txtCidade.Text = value.Festa.Endereco.Cidade;
                txtEstado.Text = value.Festa.Endereco.Estado;
                txtBairro.Text = value.Festa.Endereco.Bairro;
                txtRua.Text = value.Festa.Endereco.Rua;
                txtNumero.Text = value.Festa.Endereco.Numero;
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
