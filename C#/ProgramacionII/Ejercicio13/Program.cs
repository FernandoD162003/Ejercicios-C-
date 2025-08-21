using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{

    /// <summary>
    /// Polimorfismo - Sobrecarga
    /// Permite que un método se comporte de manera diferente según el objeto.
    /// </summary>
    public class Calculadora
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public double Sumar(double a, double b)
        {
            return a + b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancia para crear el objeto y usar sus métodos
            Calculadora calc = new Calculadora();
            Console.WriteLine("Suma int: " + calc.Sumar(3, 4));
            Console.WriteLine("Suma double: " + calc.Sumar(2.5, 3.1));
            Console.ReadLine();
        }
    }
}
