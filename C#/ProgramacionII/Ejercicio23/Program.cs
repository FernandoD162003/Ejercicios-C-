using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista (List<T>) es una estructura de datos genérica que permite almacenar una colección de elementos del mismo tipo
            //Registrar una lista de nombres introducidos por el usuario y mostrarlos.
            List<string> nombres = new List<string>();
            string entrada;

            Console.WriteLine("Ingrese nombres (escriba 'fin' para terminar):");
            do
            {
                entrada = Console.ReadLine();
                if (entrada.ToUpper() != "FIN")
                    nombres.Add(entrada);
            }
            while (entrada.ToUpper() != "FIN");

            Console.WriteLine("\nNombres ingresados:");
            foreach (string nombre in nombres)
            {
                Console.WriteLine("- " + nombre);
            }

            Console.ReadLine();
        }
    }
}
