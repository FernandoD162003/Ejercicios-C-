using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    internal class Program
    {
        /// <summary>
        /// Suma dos enteros
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sumar(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Suma dos variables de tipo double
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Sumar(double a, double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            //Sobrecarga de funciones
            Console.WriteLine("Suma int: " + Sumar(3, 4));         // 7
            Console.WriteLine("Suma double: " + Sumar(2.5, 3.1));  // 5.6

            Console.ReadLine();
        }
    }
}
