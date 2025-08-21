using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ciclos for anidados
            for (int tabla = 1; tabla <= 10; tabla++)
            {
                Console.WriteLine("Tabla del " + tabla + ":");

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(tabla + " x " + i + " = " + (tabla * i));
                }

                Console.WriteLine(); //línea en blanco entre tablas
            }

            Console.ReadKey();
        }
    }
}
