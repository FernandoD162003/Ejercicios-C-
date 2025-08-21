using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++) //Raíz cuadrada
            {
                if (numero % i == 0) //Operación de división con residuo (módulo %)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            //Valida si un número es primo
            Console.Write("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());

            if (EsPrimo(num))
                Console.WriteLine(num + " es primo");
            else
                Console.WriteLine(num + " no es primo");

            Console.ReadKey();
        }
    }
}
