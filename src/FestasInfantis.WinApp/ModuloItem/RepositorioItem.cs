using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloItens
{
    public class RepositorioItem : RepositorioBase<Item>
    {
        public List<Item> SelecionarItensDisponiveis()
        {
            return registros.Where(i => i.Tema == null).ToList();
        }
    }
}
