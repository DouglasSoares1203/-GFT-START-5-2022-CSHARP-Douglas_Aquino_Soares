using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace GFT_4.Classes
{
    public class NumerosPrimos
    {
        public NumerosPrimos()
        {
            numeros = new Collection<NumerosPrimos>();
        }

        public long Numero { get; set; }
        public int QuantidadeDeDivisores { get; set; }
        public bool EPrimo { get; set; }
        public TimeSpan tempoCalculo { get; set; }

        ICollection<NumerosPrimos> numeros { get; set; }
    }
}