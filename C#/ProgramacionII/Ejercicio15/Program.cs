using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            //While: Ejecuta mientras una condición sea verdadera. Evalúa antes de entrar.
            //Se usa cuando no sabes cuántas veces se repetirá exactamente, pero sí conoces la condición.
            while (i <= 5)
            {
                Console.WriteLine("Número: " + i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
