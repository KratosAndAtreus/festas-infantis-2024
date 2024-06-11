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


                int contadorItensSelecionados = 0;

                for (int i = 0; i < listBoxItens.Items.Count; i++)
                {
                    Item item = (Item)listBoxItens.Items[i];

                    if (value.itens.Contains(item))
                        listBoxItens.SetItemChecked(contadorItensSelecionados, true);

                    contadorItensSelecionados++;
                }
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

        public List<Item> itensMarcados
        {
            get
            {
                return listBoxItens
                    .CheckedItems
                    .Cast<Item>()
                    .ToList();
            }
        }

        public List<Item> itensDesmarcados
        {
            get
            {
                return listBoxItens
                    .Items
                    .Cast<Item>()
                    .Except(itensMarcados)
                    .ToList();
            }
        }

        public void CarregarItens(List<Item> items) 
        {
            foreach (Item i in items)
            {
                listBoxItens.Items.Add(i);
            }
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

            tema = new Tema(titulo);

            List<string> erros = tema.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
