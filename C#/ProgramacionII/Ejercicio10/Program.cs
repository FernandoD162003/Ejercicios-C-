using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        /// <summary>
        /// EJEMPLO DE ABSTRACCIÓN
        /// Oculta los detalles internos y muestra solo lo esencial.
        /// </summary>
        public abstract class Animal
        {
            public abstract void HacerSonido();
        }

        /// <summary>
        /// EJEMPLO DE HERENCIA CON SOBREESCRITURA
        /// Una clase hereda de otra para reutilizar su comportamiento.
        /// </summary>
        public class Perro : Animal
        {
            public override void HacerSonido()
            {
                Console.WriteLine("El perro dice: ¡Guau!");
            }
        }

        static void Main(string[] args)
        {
            Animal miPerro = new Perro();
            miPerro.HacerSonido();
            Console.ReadLine();
        }
    }
}
