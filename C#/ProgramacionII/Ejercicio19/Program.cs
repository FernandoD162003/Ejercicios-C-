using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Foreach: Recorre colecciones (arrays, listas, etc.) sin preocuparse por índices.
            string[] nombres = { "Luis", "Ana", "Carlos", "Diana" };

            Console.WriteLine("Lista de nombres:");
            foreach (string nombre in nombres)
            {
                Console.WriteLine("- " + nombre);
            }

            Console.ReadLine();
        }
    }
}
