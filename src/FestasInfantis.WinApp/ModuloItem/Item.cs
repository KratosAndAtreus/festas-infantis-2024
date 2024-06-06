using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FestasInfantis.WinApp.ModuloItens
{
    public class Item : EntidadeBase
    {
        
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        //public Tema Tema { get; set; }

        public Item(string descricao, decimal valor/*, string tema*/)
        {
            Descricao = descricao;
            Valor = valor;
            //this.Tema = tema;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Item atualizado = (Item)novoRegistro;

            Descricao = atualizado.Descricao;
            Valor = atualizado.Valor;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Descricao.Trim()))
                erros.Add("O campo \"descrição\" é obrigatório");

            if (Valor < 0.1m)
                erros.Add("O campo \"valor\" não pode ser menor que R$1");


            return erros;
        }

        public override string ToString()
        {
            return Descricao.ToTitleCase();
        }
    }
}
