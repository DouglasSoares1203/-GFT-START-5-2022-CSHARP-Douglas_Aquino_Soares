using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GFT_3.Entities
{
    public class Departamento
    {
        public string Nome { get; set; }

        public Departamento()
        {
            
        }

        public Departamento(string nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}