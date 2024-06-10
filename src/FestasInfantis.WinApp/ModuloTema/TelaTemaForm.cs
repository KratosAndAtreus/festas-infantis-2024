using FestasInfantis.WinApp.ModuloItens;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        private Tema tema;

        public Tema Tema
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtTitulo.Text = value.Titulo;
                numValor.Value = (decimal)value.Valor; // cast necessário
            }
            get
            {
                return tema;
            }
        }
        public TelaTemaForm()
        {
            InitializeComponent();

        }

        public void ConfigurarTela (Tema tema)
        {
            this.Tema = tema;

            txtId.Text = tema.Id.ToString();

            txtTitulo.Text = tema.Titulo;

            int i = 0;

            for (int j = 0; j < listBoxItens.Items.Count; j++)
            {
                Item item = (Item)listBoxItens.Items[j];

                listBoxItens.SetItemChecked(i, true);

                i++;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            double valor = (double)numValor.Value;

            tema = new Tema(titulo, valor);

            List<string> erros = tema.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
