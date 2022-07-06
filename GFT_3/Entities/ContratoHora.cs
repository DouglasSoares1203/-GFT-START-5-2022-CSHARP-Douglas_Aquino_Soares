using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GFT_3.Entities.Enuns;

namespace GFT_3.Entities
{
    public class ContratoHora
    {
        public DateTime DataInicial { get; set; }
        public double ValorPorHora { get; set; }
        public int Hora { get; set; }


        public ContratoHora()
        {
            
        }

        public ContratoHora(DateTime dataInicial, double valorPorHora, int hora)
        {
            DataInicial = dataInicial;
            ValorPorHora = valorPorHora;
            Hora = hora;   
        }

        public double ValorTotal()
        {
            return ValorPorHora * Hora;
        }
    }
}