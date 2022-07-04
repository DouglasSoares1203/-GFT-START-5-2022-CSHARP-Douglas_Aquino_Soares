using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GFT_3
{
    public class Trabalhador 
    {
        public Trabalhador() 
        {
            this.Nome = "";
            this.Salario = 0;
            this.SalarioPorHora = 0;
            this.HorasTrabalhadas = DateTime.UtcNow;
        }

        public Trabalhador(  double salario,string nome, double salarioPorHora, DateTime horasTrabalhadas)
        {
            
            this.Salario = salario;
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

        private double _salario;
        public double Salario 
        { 
            get{return _salario;} 
            set{_salario = value;} 
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

        


       public void  SetNome(string Nome)
        {
             int i = 0;
            while (i < 5)
            {
                this.Nome = Nome;
                i++;
            }
                
        }
            
           //Console.WriteLine(Nome.ToString());           
       

       public string GetNome()
       {            
            return  this.Nome;         
       }


        public void SetSalarioPorHora(double Salario, double SalarioPorHora)
        {
            int HorasMensal = 220;

            this.Salario = Salario;
            this.SalarioPorHora = SalarioPorHora;
            
            SalarioPorHora = Salario/HorasMensal;
        
        }
        
        public double GetSalarioPorHora()
        {
           return  Salario + SalarioPorHora;
        }

        
        public void SetHorasTrabalhadas(DateTime HorasTrabalhadas)
        {

            this.HorasTrabalhadas = HorasTrabalhadas;
            HorasTrabalhadas =  DateTime.Parse("%h");
        }

         public DateTime GetHorasTrabalhadas()
        {

            return HorasTrabalhadas;
        }

        public double GetSalarioTotal()
        {
            return SalarioTotal;
        }

    }   
}