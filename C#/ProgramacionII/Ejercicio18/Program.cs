using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For: Ideal para ciclos contados (inicialización; condición; incremento)
            Console.WriteLine("Tabla del 3:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"3 x {i} = {3 * i}");
            }
            Console.ReadLine();
        }
    }
}
