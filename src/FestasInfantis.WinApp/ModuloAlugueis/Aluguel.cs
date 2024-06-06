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

        public Enum PorcentagemEntrada { get; set; }

        public double PorcentagemDesconto { get; set; }

        public DateTime DataPagamento { get; set; }

        public bool status;

        public string festa;

        public Aluguel(Cliente cliente, Tema tema, Enum porcentagemEntrada, double porcentagemDesconto, DateTime dataPagamento, bool status, string festa)
        {
            Cliente = cliente;
            Tema = tema;
            PorcentagemEntrada = porcentagemEntrada;
            PorcentagemDesconto = porcentagemDesconto;
            DataPagamento = dataPagamento;
            this.status = status;
            this.festa = festa;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            //if (string.IsNullOrEmpty(Cliente.Trim()))
            //    erros.Add("O campo \"nome\" é obrigatório");

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
            PorcentagemEntrada = aluguel.PorcentagemEntrada;
            PorcentagemDesconto = aluguel.PorcentagemDesconto;
            DataPagamento = aluguel.DataPagamento;
            status = aluguel.status;
            festa = aluguel.festa;
        }

        public override string ToString()
        {
            string i = "ok"; 
            return i;
        }
    }
}
