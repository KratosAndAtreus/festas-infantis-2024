using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloItens;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class Tema : EntidadeBase
    {
        public string Titulo;
        public double Valor;
        public List<Item> itens;

        public Tema(string titulo, double valor/*, List<Item> itens*/)
        {
            Titulo = titulo;
            Valor = valor;
            //this.itens = itens;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Tema atualizado = (Tema)novoRegistro;

            Titulo = atualizado.Titulo;
            Valor = atualizado.Valor;
            this.itens = atualizado.itens;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Titulo.Trim()))
                erros.Add("O campo \"Título\" é obrigatório");

            if (Valor < 1)
                erros.Add("O campo \"valor\" não pode ser menor que R$1");

            return erros;
        }

        public override string ToString()
        {
            return Titulo.ToTitleCase();
        }
    }
}
