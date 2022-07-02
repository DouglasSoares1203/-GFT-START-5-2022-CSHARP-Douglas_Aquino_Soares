using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GFT_2.Interfaces;

namespace GFT_2.Classes
{
    public class Cheques : IRecebivel
    {

        public Cheques() 
        {
            this.TipoRecebivel = 0;
            this.Recebiveis = 1500;
            this.Valor = 0;
        }

        public Cheques( int tipoRecebivel, double valor, double promissoria) 
        {
            this.TipoRecebivel = tipoRecebivel;
            this.Valor = valor;
            this.Recebiveis = promissoria;

        }
        private int _tipoRecebivel;
        public int  TipoRecebivel
        { 
            get{return _tipoRecebivel;} 
            set{_tipoRecebivel = value;} 
        }
        private double _valor;
        public double  Valor
        { 
            get{return _valor;} 
            set{_valor = value;} 
        }

        private double _recebiveis;

        public double Recebiveis 
        { 
            get{return _recebiveis;} 
            set{_recebiveis = value;} 
        }

        public void calcularValorRecebivel()
        {
          
          if (TipoRecebivel == 30)
          {
            this.Valor = (Recebiveis * 0.05) + Recebiveis;
          }
          if (TipoRecebivel == 60)
          {
            this.Valor = (Recebiveis * 0.075) + Recebiveis;
          }
          if (TipoRecebivel == 90)
          {
            this.Valor = (Recebiveis * 0.10) + Recebiveis;
          }
           if (TipoRecebivel > 90)
          {
            this.Valor = (Recebiveis * 0.085 * (+ 2 * 0.03)) + Recebiveis;
          }
           
          
          Console.WriteLine("O Valor do Cheque será: " + this.Valor);

        }

        
    }
}