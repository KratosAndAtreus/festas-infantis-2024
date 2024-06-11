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

        public List<Item> SelecionarItensDisponiveis(Tema temaSelecionado)
        {
            var registroSelecionado = registros
                .Where(i => i.Tema != null)
                .Where(i => i.Tema.Id == temaSelecionado.Id);

            return registros
                .Where(i => i.Tema == null)
                .Concat(registroSelecionado)
                .ToList();
        }
    }
}
