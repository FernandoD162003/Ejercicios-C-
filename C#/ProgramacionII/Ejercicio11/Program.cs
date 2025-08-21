using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    /// <summary>
    /// EJEMPLO ENCAPSULAMIENTO
    /// Protege los datos usando propiedades y control de acceso (private, public).
    /// </summary>
    public class Persona
    {
        //MODIFICADOR DE ACCESO
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    nombre = value;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancia a persona, agrega información e imprime.
            Persona persona = new Persona();
            persona.Nombre = "Carlos";
            Console.WriteLine("Nombre: " + persona.Nombre);
            Console.ReadLine();
        }
    }
}
