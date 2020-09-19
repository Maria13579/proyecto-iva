using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iva
{
    class Program
    {
        static opera oper = new opera();
        static Menu m = new Menu();
        static void Main(string[] args)
        {
            int opciones = 0;
            while (opciones!=3)
            {
                opciones = m.ListaMenu();
                Console.Clear();
                if (opciones == 1)
                {
                    Console.WriteLine(oper.Resultado('c'));
                }    
                else if (opciones==2)
                {
                    Console.WriteLine(oper.Resultado('i'));
                }
            }
            if (opciones == 3)
            {
                Console.WriteLine("Gracias por usar nuestra aplicacion");
            }
            Console.ReadKey();
        }
    }
}
