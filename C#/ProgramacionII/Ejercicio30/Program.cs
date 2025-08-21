using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class Vehiculo
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public virtual void MostrarDatos()
        {
            Console.WriteLine($"Placa: {Placa}, Marca: {Marca}, Modelo: {Modelo}");
        }
    }

    class Bus : Vehiculo
    {
        public int CapacidadPasajeros { get; set; }
        public string RutaAsignada { get; set; }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Capacidad: {CapacidadPasajeros}, Ruta: {RutaAsignada}");
        }
    }

    class EmpresaTransporte
    {
        private List<Bus> buses = new List<Bus>();

        public void AgregarBus(Bus bus)
        {
            buses.Add(bus);
            Console.WriteLine("Bus agregado correctamente.\n");
        }

        public void MostrarBuses()
        {
            if (buses.Count == 0)
            {
                Console.WriteLine("No hay buses registrados.\n");
                return;
            }

            foreach (var bus in buses)
            {
                bus.MostrarDatos();
                Console.WriteLine("-----------------------");
            }
        }

        public void BuscarPorPlaca(string placa)
        {
            var bus = buses.Find(b => b.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase)); //Compara dos cadenas ignorando minusculas y mayúsculas.
            if (bus != null)
            {
                Console.WriteLine("Bus encontrado:");
                bus.MostrarDatos();
            }
            else
            {
                Console.WriteLine("Bus no encontrado.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Una empresa de transporte desea llevar el control de sus buses y sus rutas asignadas.
            //Repaso general.
            EmpresaTransporte empresa = new EmpresaTransporte();
            int opcion;

            do
            {
                Console.WriteLine("=== Menú ===");
                Console.WriteLine("1. Agregar Bus");
                Console.WriteLine("2. Mostrar Buses");
                Console.WriteLine("3. Buscar Bus por Placa");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Bus nuevoBus = new Bus();

                        Console.Write("Ingrese placa: ");
                        nuevoBus.Placa = Console.ReadLine();

                        Console.Write("Ingrese marca: ");
                        nuevoBus.Marca = Console.ReadLine();

                        Console.Write("Ingrese modelo: ");
                        nuevoBus.Modelo = Console.ReadLine();

                        Console.Write("Ingrese capacidad: ");
                        nuevoBus.CapacidadPasajeros = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese ruta asignada: ");
                        nuevoBus.RutaAsignada = Console.ReadLine();

                        empresa.AgregarBus(nuevoBus);
                        break;

                    case 2:
                        empresa.MostrarBuses();
                        break;

                    case 3:
                        Console.Write("Ingrese la placa a buscar: ");
                        string placa = Console.ReadLine();
                        empresa.BuscarPorPlaca(placa);
                        break;

                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.\n");
                        break;
                }

            } while (opcion != 4);
        }
    }
}
