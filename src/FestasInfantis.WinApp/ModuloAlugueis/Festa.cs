using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FestasInfantis.WinApp.ModuloAlugueis
{
    public class Festa
    {

        public Endereco Endereco { get; set; }

        public DateTime Data {  get; set; }

        public TimeSpan HorarioInicio { get; set; }

        public TimeSpan HorarioTermino { get; set; }

        public Festa()
        {
        }
        public Festa(Endereco endereco, DateTime data, TimeSpan horarioInicio, TimeSpan horarioTermino)
        {
            Endereco = endereco;
            Data = data;
            HorarioInicio = horarioInicio;
            HorarioTermino = horarioTermino;
        }

        public List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (Endereco == null)
                erros.Add("O campo \"Endereço\" é obrigatório");
            else
            {
                // Validar o endereço usando o método Validar da classe Endereco
                erros.AddRange(Endereco.Validar());
            }

            if (Data == DateTime.MinValue)
                erros.Add("O campo \"Data\" é obrigatório");

            if (HorarioInicio == TimeSpan.Zero)
                erros.Add("O campo \"Horário de Início\" é obrigatório");

            if (HorarioTermino == TimeSpan.Zero)
                erros.Add("O campo \"Horário de Término\" é obrigatório");

            if (HorarioInicio >= HorarioTermino)
                erros.Add("O horário de término deve ser após o horário de início");

            return erros;
        }
    }
}
