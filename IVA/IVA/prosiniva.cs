using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iva
{

   
    class prosiniva
    {
        private double opeiva = 1.12;
        private double b = 0;
        public double Prodsiniva (double a)
        {
            b = a / opeiva;
            return b;
        }

        public double ivadelproducto(double a)
        {
            b = a / opeiva;
            return (a - b);
        }
    }
}
