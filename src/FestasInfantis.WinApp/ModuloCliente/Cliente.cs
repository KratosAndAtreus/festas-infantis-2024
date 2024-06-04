using eAgenda.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class Cliente : EntidadeBase
    { 
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }

        public Cliente(string nome, string telefone, string cpf)
        {
            Nome = nome;
            Telefone = telefone;
            CPF = cpf;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (string.IsNullOrEmpty(CPF.Trim()))
                erros.Add("O Campo \"CPF\" é obrigatório");

            if (string.IsNullOrEmpty(Telefone.Trim()))
                erros.Add("O campo \"telefone\" é obrigatório");


            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
           Cliente cliente = (Cliente)novoRegistro;

            Nome = cliente.Nome;
            Telefone = cliente.Telefone;
            CPF = cliente.CPF;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Telefone: {Telefone}," +
                $" CPF: {CPF}";
        }

    }
}
