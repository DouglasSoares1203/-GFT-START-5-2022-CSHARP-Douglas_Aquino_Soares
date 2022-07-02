using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GFT_3.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);        
        void Insere(T entidade); 
        int ProximoId();
    }
}