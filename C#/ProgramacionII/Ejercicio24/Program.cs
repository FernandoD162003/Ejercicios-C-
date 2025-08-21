using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escritura de archivos
            //Guardar nombres en un archivo de texto (nombres.txt).

            //Lista de tipo String
            List<string> nombres = new List<string>();
            string entrada;

            Console.WriteLine("Ingrese nombres para guardar en archivo (escriba 'fin' para terminar):");
            do
            {
                entrada = Console.ReadLine();
                if (entrada.ToUpper() != "FIN")
                    nombres.Add(entrada);
            }
            while (entrada.ToUpper() != "FIN");

            string ruta = "nombres.txt";

            //Escribe o sobreescribe el archivo en la ruta especificada con la lista.
            File.WriteAllLines(ruta, nombres);

            Console.WriteLine("\nArchivo creado exitosamente: " + ruta);
            Console.ReadLine();
        }
    }
}
