using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace iva
{
    class opera:prosiniva
    {
        public prosiniva ope = new prosiniva();
        public string Resultado(char t)
        {
            double total = 0;
            char op = 's';
            while (op != 'n')
            {
                if(t=='c')
                {
                    total = ope.Prodsiniva(Pedir());
                }
                else if(t=='i')
                {
                    total = ope.ivadelproducto(Pedir());
                }
                Console.WriteLine("Desea ingresar otro producto [s/n]");
                op = char.Parse(Console.ReadLine());

            }
            return ("El resultado es: " + total);
        }
        private double Pedir()
        {
            double producto = 0;
            bool estado = false;
            while(estado== false)
            {
                Console.WriteLine("Ingrese el precio del producto");
                try
                {
                    producto = double.Parse(Console.ReadLine());
                    estado = true;
                }
                catch
                {
                    Console.WriteLine("Solo valores numericos...");
                }
            }
            return producto;
        }
    }

}
