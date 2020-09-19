using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iva
{
    class Menu
    {
        private int op = 0;
        public int ListaMenu ()
        {
            Console.WriteLine("-------------Menu-------------");
            Console.WriteLine("1. Producto sin Iva");
            Console.WriteLine("2. Iva del Producto");
            Console.WriteLine("3. Salir");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Digite el numero de opcion que desea:");
            op = int.Parse(Console.ReadLine());
            return op;
            

        }
    }
}
