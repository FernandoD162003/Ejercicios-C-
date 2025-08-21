using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Repaso de ciclo for.
            Console.WriteLine("Tabla del 1:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("1 x " + i + " = " + (1 * i));
            }

            Console.ReadKey();
        }
    }
}
