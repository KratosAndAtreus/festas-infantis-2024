using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloItens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class RepositorioTema : RepositorioBase<Tema>
    {

        public override bool Excluir(int id)
        {
            Tema tema = SelecionarPorId(id);

            if (tema.itens.Any())
            {
                foreach (Item i in tema.itens)
                {
                    i.RemoverTema();
                }

            }
               return base.Excluir(id);
        }

        public void AdicionarItens(Tema novoTema, List<Item> itensMarcados)
        {
            foreach (Item item in itensMarcados)
            {
                novoTema.AdicionarItem(item);
            }
        }
    }
}
