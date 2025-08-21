using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Respaso Do - While: Pedir una clave al usuario hasta que escriba "1234".
            string clave;
            do
            {
                Console.Write("Ingrese la clave: ");
                clave = Console.ReadLine();
            }
            while (clave != "1234");

            Console.WriteLine("¡Acceso concedido!");
            Console.ReadLine();
        }
    }
}
