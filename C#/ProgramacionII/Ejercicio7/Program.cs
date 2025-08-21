using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Carne { get; set; }

        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Carné: " + Carne);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Crea un clase y le asigna información
            Estudiante estudiante = new Estudiante();

            Console.Write("Nombre: ");
            estudiante.Nombre = Console.ReadLine();

            Console.Write("Edad: ");
            estudiante.Edad = int.Parse(Console.ReadLine());

            Console.Write("Carné: ");
            estudiante.Carne = Console.ReadLine();

            estudiante.MostrarDatos();
            Console.ReadKey();
        }
    }
}
