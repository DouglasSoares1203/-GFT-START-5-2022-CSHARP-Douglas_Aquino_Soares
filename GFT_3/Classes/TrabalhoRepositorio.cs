using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GFT_3.Interfaces;

namespace GFT_3.Classes
{
    
    public class TrabalhoRepositorio : IRepositorio<Trabalhador>
    {
        private List<Trabalhador> listaTrabalhador = new List<Trabalhador>();
        public void Insere(Trabalhador objeto)
        {
            listaTrabalhador.Add(objeto);
        }

        public List<Trabalhador> Lista()
        {
            return listaTrabalhador;
        }

        public int ProximoId()
        {
            return listaTrabalhador.Count;
        }

        public Trabalhador RetornaPorId(int id)
        {
            return listaTrabalhador[id];
        }
    }
}