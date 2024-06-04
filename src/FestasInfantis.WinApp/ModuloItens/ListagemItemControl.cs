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
    public partial class ListagemItemControl : UserControl
    {
        public ListagemItemControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Item> itens)
        {
            listItens.Items.Clear();

            foreach (Item item in itens)
                listItens.Items.Add(item);
        }

        public Item ObterRegistroSelecionado()
        {

            if (listItens.SelectedItems == null)
                return null;

            return (Item)listItens.SelectedItem;
        }

        private void listContatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
