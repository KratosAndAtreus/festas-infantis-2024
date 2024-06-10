using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloItens;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class Tema : EntidadeBase
    {
        public string Titulo;
        public List<Item> itens { get; set; } = new List<Item>();
        public decimal Valor 
        {
            get
            { 
                decimal valor = 0;

                foreach (Item i in itens)
                    valor += i.Valor;

                    return valor;
                
            } 
        }

        public Tema() { }

        public Tema(string titulo)
        {
            Titulo = titulo;
        }

        public bool AdicionarItem(Item item)
        {
            if (itens.Contains(item))
                return false;

            itens.Add(item);

            item.AtribuirTema(this);

            return true;
        }

        public bool RemoverItem(Item item)
        {
            if(!itens.Contains(item))
                return false ;

            itens.Remove(item);

            item.RemoverTema();

            return true;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Tema atualizado = (Tema)novoRegistro;

            Titulo = atualizado.Titulo;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Titulo.Trim()))
                erros.Add("O campo \"Título\" é obrigatório");

            return erros;
        }

        public override string ToString()
        {
            return Titulo.ToTitleCase();
        }
    }
}
