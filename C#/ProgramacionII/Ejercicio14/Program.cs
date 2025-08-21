using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    /// <summary>
    /// HERENCIA
    /// Una clase hereda de otra para reutilizar su comportamiento.
    /// </summary>
    public class Vehiculo
    {
        public void Encender()
        {
            Console.WriteLine("El vehículo está encendido.");
        }
    }

    /// <summary>
    /// Carro hereda de Vehiculo
    /// </summary>
    public class Carro : Vehiculo
    {
        public void TocarBocina()
        {
            Console.WriteLine("BEEP BEEP!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancia la clase para usar los métodos en el objeto
            Carro miCarro = new Carro();
            miCarro.Encender();
            miCarro.TocarBocina();
            Console.ReadLine();
        }
    }
}
