using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GFT_2.Interfaces;

namespace GFT_2.Classes
{
    public class TitulosDoGoverno : IRecebivel
    {
        
            public TitulosDoGoverno() 
            {
                this.TipoRecebivel = 0;
                this.Recebiveis = 1500;
                this.Valor = 0;
            }

            public TitulosDoGoverno( int tipoRecebivel, double valor, double promissoria) 
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
                this.Valor = (Recebiveis * 0.03) + Recebiveis;
            }
            if (TipoRecebivel == 60)
            {
                this.Valor = (Recebiveis * 0.055) + Recebiveis;
            }
            if (TipoRecebivel == 90)
            {
                this.Valor = (Recebiveis * 0.065) + Recebiveis;
            }
            if (TipoRecebivel > 90)
            {
                this.Valor = (Recebiveis * 0.085 * (+ 2 * 0.01)) + Recebiveis;
            }
            
            Console.WriteLine("O Valor do Titulo do Governo será: " + this.Valor);
            }
    }
}