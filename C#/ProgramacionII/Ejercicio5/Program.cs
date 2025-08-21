using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos: Es una estructura de datos que permite almacenar múltiples elementos del mismo tipo en una única variable
            //Arreglo inicializado
            double[] notas = new double[5];
            double suma = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Ingrese la nota " + (i + 1) + ": ");
                notas[i] = double.Parse(Console.ReadLine());
                suma += notas[i];
            }

            double promedio = suma / notas.Length;
            Console.WriteLine("Promedio: " + promedio);
            Console.ReadKey();
        }
    }
}
