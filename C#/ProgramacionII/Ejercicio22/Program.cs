using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglo: es una estructura de datos que almacena una colección de elementos del mismo tipo, bajo un único nombre de variable
            //Crea un arreglo de enteros y mostrar sus elementos y suma total
            int[] numeros = { 10, 20, 30, 40, 50 };
            int suma = 0;

            Console.WriteLine("Elementos del arreglo:");
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
                suma += num;
            }

            Console.WriteLine("Suma total: " + suma);
            Console.ReadLine();
        }
    }
}
