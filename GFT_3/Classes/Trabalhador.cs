using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GFT_3
{
    public class Trabalhador : EntidadeBase
    {
        public Trabalhador() 
        {
            this.Nome = "";
            this.SalarioPorHora = 0;
            this.HorasTrabalhadas = DateTime.UtcNow;
        }

        public Trabalhador( int id,string nome, double salarioPorHora, DateTime horasTrabalhadas)
        {
            this.Id = id;
            this.Nome = nome;
            this.SalarioPorHora = salarioPorHora;
            this.HorasTrabalhadas = horasTrabalhadas;
        }


        private string _nome;
        public string Nome 
        { 
            get{return _nome;} 
            set{_nome = value;} 
        }
        private double _salarioPorHora;
        public double SalarioPorHora 
        { 
            get{return _salarioPorHora;} 
            set{_salarioPorHora = value;} 
        }

        private DateTime HorasTrabalhadas;
        public int _horasTrabalhadas 
        { 
            get{return _horasTrabalhadas;} 
            set{_horasTrabalhadas = value;} 
        }
        
        private double _salarioTotal;
        public double SalarioTotal
        {
            get{return _salarioTotal;}
        }

        public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Nome: " + this.Nome + Environment.NewLine;
            retorno += "SalarioPorHora: " + this.SalarioPorHora + Environment.NewLine;
            retorno += "HorasTrabalhadas: " + this.HorasTrabalhadas + Environment.NewLine;
            
			return retorno;
		}


        public string RetornaNome()
        {
            return this.Nome;
        }

        public double RetornaSalarioPorHora()
        {
            return this.SalarioPorHora;
        }

        public DateTime RetornarHorasTrabalhadas()
        {
            return this.HorasTrabalhadas;
        }



        public void LimitedeTrabalhador()
        {
            do
            {
                Console.WriteLine(Nome.ToString());
            } 
            while (Nome.Length <= 5);
        }



    }   
}