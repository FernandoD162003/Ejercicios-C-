using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For: estructura de control iterativa ejecutando el bloque de código n cantidad de veces.
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
