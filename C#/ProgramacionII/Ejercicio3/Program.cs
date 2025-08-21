using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sentencia de control if (operadores condicional >=, <, > <=)
            Console.Write("Ingrese la nota (0-100): ");
            int nota = int.Parse(Console.ReadLine());

            if (nota >= 61)
                Console.WriteLine("Aprobado");
            else
                Console.WriteLine("Reprobado");

            if (nota > 100)
            {
                Console.WriteLine("Corrección la nota no puede superar 100.");
            }
            else if(nota >= 90)
            {
                Console.WriteLine("Tu nota te permitirá exonerarte de evaluación privada.");
            }

            Console.ReadKey();
        }
    }
}
