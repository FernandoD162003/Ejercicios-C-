using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    public interface ISaludable
    {
        void Saludar();
    }

    public class Persona : ISaludable
    {
        public void Saludar()
        {
            Console.WriteLine("¡Hola! Soy una persona saludable.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Una interfaz es un contrato que una clase debe cumplir. Solo contiene la firma de los métodos, no la implementación.
            ISaludable persona = new Persona();
            persona.Saludar();

            Console.ReadLine();
        }
    }
}
