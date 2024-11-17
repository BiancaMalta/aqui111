using System;
using System.ComponentModel;
using System.Globalization;

namespace CadastroEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; } = DateTime.Now;
        public TimeSpan HoraInicio { get; set; } = DateTime.Now.TimeOfDay;
        public DateTime DataTermino { get; set; } = DateTime.Now;
        public TimeSpan HoraTermino { get; set; } = DateTime.Now.TimeOfDay;
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }

        // Combinação de data e hora
        public DateTime InicioCompleto => DataInicio.Date + HoraInicio;
        public DateTime TerminoCompleto => DataTermino.Date + HoraTermino;

        // Cálculo da duração em dias e horas
        public TimeSpan Duracao => TerminoCompleto - InicioCompleto;

        public string DuracaoFormatada
        {
            get
            {
                var dias = Duracao.Days;
                var horas = Duracao.Hours;
                var minutos = Duracao.Minutes;

                string resultado = $"{dias} dia(s)";
                if (horas > 0) resultado += $", {horas} hora(s)";
                if (minutos > 0) resultado += $", {minutos} minuto(s)";

                return resultado;
            }
        }

        // Propriedade calculada para obter o custo total
        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }
}