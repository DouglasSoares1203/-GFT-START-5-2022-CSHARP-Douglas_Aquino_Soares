using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GFT_3.Entities.Enuns;

namespace GFT_3.Entities
{
    class Funcionarios
    {
        public string Nome { get; set; }
        public ExperienciaNivel Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<ContratoHora> Contratos { get; set; } = new List<ContratoHora>();
    
        public Funcionarios()
        {
            
        }

        public Funcionarios(string nome, ExperienciaNivel nivel,double salarioBase, Departamento departamento)
        {
           Nome = nome;
           Nivel = nivel;
           SalarioBase = salarioBase;
           Departamento = departamento;
        }

        public void AdicionarContrato(ContratoHora contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoverContrato(ContratoHora contrato)
        {
            Contratos.Remove(contrato);
        }

        public double Inicio(int ano, int mês)
        {
            double total = SalarioBase;

            foreach (ContratoHora contrato in Contratos)
            {
                if (contrato.DataInicial.Year == ano && contrato.DataInicial.Month == mês)
                {
                    total += contrato.ValorTotal();
                }
            }
            return total;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + "\n" + "Departamento: " + Departamento;
        }
    }
}