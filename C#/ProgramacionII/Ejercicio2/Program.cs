using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sentencia de control switch y operaciones matemáticas.
            Console.Write("Ingresa el primer número: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Operación (+ - * /): ");
            char op = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch (op)
            {
                case '+': resultado = a + b; break;
                case '-': resultado = a - b; break;
                case '*': resultado = a * b; break;
                case '/': resultado = (b != 0) ? a / b : 0; break; //Uso de operador ternario, forma consisa de expresar un operador condicional.
                default:
                    Console.WriteLine("Operación inválida.");
                    Console.ReadKey();
                    return;
            }

            Console.WriteLine("Resultado: " + resultado);
            Console.ReadKey();
        }
    }
}
