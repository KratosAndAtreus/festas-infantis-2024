using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class ListagemTemaControl : UserControl
    {
        public ListagemTemaControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Tema> temas)
        {
            listTemas.Items.Clear();

            foreach (Tema tema in temas)
                listTemas.Items.Add(tema);
        }

        public Tema ObterRegistroSelecionado()
        {

            if (listTemas.SelectedItems == null)
                return null;

            return (Tema)listTemas.SelectedItem;
        }

        private void listContatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
