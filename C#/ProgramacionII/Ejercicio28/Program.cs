using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio28
{
    internal class Program
    {
        // Usando ref: se utiliza para pasar argumentos a métodos por referencia
        static void Duplicar(ref int numero)
        {
            numero = numero * 2;
        }

        // Usando out: se usa para pasar argumentos a métodos por referencia, permitiendo que el método modifique el valor del argumento y que el llamador vea el cambio (inicializado)
        static void ObtenerFecha(out string fecha)
        {
            fecha = DateTime.Now.ToShortDateString();
        }

        static void Main(string[] args)
        {
            //ref requiere que el argumento sea inicializado antes de ser pasado, mientras que out no.
            //Un método con un parámetro out debe asignar un valor al parámetro antes de devolverlo, mientras que con ref esto no es obligatorio. 

            int valor = 10;
            Duplicar(ref valor);
            Console.WriteLine("Valor duplicado: " + valor); //20

            string hoy;
            ObtenerFecha(out hoy);
            Console.WriteLine("Fecha de hoy: " + hoy);

            Console.ReadLine();
        }
    }
}
