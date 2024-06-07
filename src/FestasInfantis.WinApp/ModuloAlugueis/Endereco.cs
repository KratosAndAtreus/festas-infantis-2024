using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloTema;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloAlugueis
{
    public class Endereco
    {
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }

        public Endereco()
        {
            Rua = null;
            Numero = null;
            Cidade = null;
            Estado = null;
            Bairro = null;
        }

        public Endereco(string rua, string numero, string cidade, string estado, string cep)
        {
            Rua = rua;
            Numero = numero;
            Cidade = cidade;
            Estado = estado;
            Bairro = cep;
        }

        public List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Rua.Trim()))
                erros.Add("O campo \"Rua\" é obrigatório");

            if (string.IsNullOrEmpty(Numero.Trim()))
                erros.Add("O campo \"Numero\" é obrigatório");

            if (string.IsNullOrEmpty(Cidade.Trim()))
                erros.Add("O campo \"Cidade\" é obrigatório");

            if (string.IsNullOrEmpty(Estado.Trim()))
                erros.Add("O campo \"Estado\" é obrigatório");

            if (string.IsNullOrEmpty(Bairro.Trim()))
                erros.Add("O campo \"Bairro\" é obrigatório");

            return erros;
        }
    }
}
