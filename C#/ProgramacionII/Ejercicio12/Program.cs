using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{

    /// <summary>
    /// POLIMORFISMO
    /// Permite que un método se comporte de manera diferente según el objeto.
    /// </summary>
    public class Animal
    {
        public virtual void Hablar()
        {
            Console.WriteLine("El animal hace un sonido.");
        }
    }

    /// <summary>
    /// HERENCIA
    /// </summary>
    public class Gato : Animal
    {
        public override void Hablar()
        {
            Console.WriteLine("El gato dice: Miau.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancia para crear el objeto.
            Animal miAnimal = new Gato();
            miAnimal.Hablar();
            Console.ReadLine();
        }
    }
}
