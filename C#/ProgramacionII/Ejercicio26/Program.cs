using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    internal class Program
    {
        /// <summary>
        /// Función con parámetros
        /// </summary>
        /// <param name="nombre"></param>
        static void SaludarPersona(string nombre)
        {
            Console.WriteLine("Hola " + nombre + ", ¿cómo estás?");
        }

        static void Main(string[] args)
        {
            //Función con parámetros

            //Llama a la función enviando un parámetro.
            SaludarPersona("Carlos");
            Console.ReadLine();
        }
    }
}
