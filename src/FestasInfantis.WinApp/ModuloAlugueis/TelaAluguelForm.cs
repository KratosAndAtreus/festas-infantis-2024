using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;
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

            CarregarSinal();
        }

        public void CarregarClientes(List<Cliente> clientes)
        {
            cmbClientes.Items.Clear();

            foreach (Cliente c in clientes)
                cmbClientes.Items.Add(c);
        }

        public void CarregarTemas(List<Tema> temas)
        {
            cmbTema.Items.Clear();

            foreach (Tema t in temas)
                cmbTema.Items.Add(t);
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            ValorSinalEnum sinal =
                (ValorSinalEnum)cmbSinal.SelectedItem;
            
            Tema tema = (Tema)cmbTema.SelectedItem;
            Cliente cliente = (Cliente)cmbClientes.SelectedItem;

            string cidade = txtCidade.Text;
            string estado = txtEstado.Text;
            string bairro = txtBairro.Text;
            string rua = txtRua.Text;
            string numero = txtNumero.Text;

            Endereco endereco = new Endereco(rua, numero, cidade, estado, bairro);

            DateTime data = dtFesta.Value;
            TimeSpan horaInicio = TimeSpan.Parse(mskHoraInicio.Text);
            TimeSpan horaTermino = TimeSpan.Parse(mskHoraTermino.Text);


            Festa festa = new Festa(endereco, data, horaInicio, horaTermino);

            aluguel = new Aluguel(cliente, tema, sinal, festa);

            List<string> erros = aluguel.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        

        private void CarregarSinal()
        {
            Array valoresEnum = Enum.GetValues(typeof(ValorSinalEnum));

            foreach (var valor in valoresEnum)
                cmbSinal.Items.Add(valor);

            cmbSinal.SelectedItem = ValorSinalEnum.Sinal40;
        }
    }
}
