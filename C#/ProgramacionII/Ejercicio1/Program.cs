using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intradas y salida de información.
            Console.Write("Ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Ingresa tu carrera: ");
            string carrera = Console.ReadLine();

            Console.WriteLine("Hola " + nombre + ", tienes " + edad + " años y estudias " + carrera + ".");
            Console.ReadKey();
        }
    }
}
