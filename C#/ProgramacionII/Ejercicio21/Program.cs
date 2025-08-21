using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    struct Producto
    {
        private string Nombre; //Modificador de acceso
        public double Precio;

        //Constructor que permite inicializar campos.
        public Producto(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Producto: {Nombre}, Precio: Q{Precio}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Estructura (Struct): tipo de valor que agrupa campos relacionados para representar una entidad única
            Producto prod1 = new Producto("Laptop", 3500);
            Producto prod2 = new Producto("Mouse", 150);

            prod1.Mostrar();
            prod2.Mostrar();

            Console.ReadLine();
        }
    }
}
