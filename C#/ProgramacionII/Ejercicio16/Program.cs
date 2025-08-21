using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 1;
            //Do - While: Ejecuta al menos una vez, y luego sigue si la condición es verdadera.
            //Ideal cuando se necesita que la acción ocurra al menos una vez, por ejemplo: pedir contraseña hasta que sea correcta.
            do
            {
                Console.WriteLine("Número: " + j);
                j++;
            }
            while (j <= 5);

            Console.ReadLine();
        }
    }
}
