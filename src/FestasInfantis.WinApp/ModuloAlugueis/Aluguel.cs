using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloAlugueis
{
    public class Aluguel : EntidadeBase
    {
        public Cliente Cliente { get; set; }

        public Tema Tema { get; set; }

        public Festa Festa {  get; set; }

        public ValorSinalEnum Sinal { get; set; }

        public double PorcentagemDesconto { get; set; }

        public DateTime DataPagamento { get; set; }

        public bool EstaAlugado { get; set; } = true;


        public Aluguel(Cliente cliente, Tema tema, ValorSinalEnum porcentagemEntrada, Festa festa/*, double porcentagemDesconto*/)
        { 
            Cliente = cliente;
            Tema = tema;
            Sinal = porcentagemEntrada;
            Festa = festa;
            //PorcentagemDesconto = porcentagemDesconto;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (Cliente == null)
                erros.Add("O campo \"Cliente\" é obrigatório");

            //if (string.IsNullOrEmpty(CPF.Trim()))
            //    erros.Add("O Campo \"CPF\" é obrigatório");

            //if (string.IsNullOrEmpty(Telefone.Trim()))
            //    erros.Add("O campo \"telefone\" é obrigatório");


            return erros;
        }
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Aluguel aluguel = (Aluguel)novoRegistro;

            Cliente = aluguel.Cliente;
            Tema = aluguel.Tema;
            Festa = aluguel.Festa;
            Sinal = aluguel.Sinal;
            PorcentagemDesconto = aluguel.PorcentagemDesconto;
            DataPagamento = aluguel.DataPagamento;
            EstaAlugado = aluguel.EstaAlugado;
        }

        public override string ToString()
        {
            string i = "ok"; 
            return i;
        }
    }
}
