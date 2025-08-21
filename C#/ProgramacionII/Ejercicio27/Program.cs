using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    internal class Program
    {
        /// <summary>
        /// Función que recibe dos valores enteros como parámetros y devuelve la sumatoria (tipo entero).
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sumar(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            //Función que devuelve un valor.
            int resultado = Sumar(5, 7);
            Console.WriteLine("Resultado: " + resultado);
            Console.ReadLine();
        }
    }
}
