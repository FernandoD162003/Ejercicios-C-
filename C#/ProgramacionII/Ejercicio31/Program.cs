/*
 * Ejercicio 31: Generador de Links de Perfil
 * Este programa genera links para compartir el perfil del desarrollador
 * Demuestra el uso de strings, concatenación y métodos
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class PerfilDesarrollador
    {
        public string NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }

        public void MostrarLinksCompartir()
        {
            Console.WriteLine("🔗 LINKS PARA COMPARTIR MI PERFIL 🔗");
            Console.WriteLine("=====================================");
            Console.WriteLine($"👤 Desarrollador: {Nombre}");
            Console.WriteLine($"💻 Especialidad: {Especialidad}");
            Console.WriteLine("");
            
            // Links para compartir
            string perfilGitHub = $"https://github.com/{NombreUsuario}";
            string repositorio = $"https://github.com/{NombreUsuario}/Ejercicios-C-";
            string starRepo = $"https://github.com/{NombreUsuario}/Ejercicios-C-/stargazers";
            
            Console.WriteLine("📋 COPIA Y COMPARTE ESTOS LINKS:");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"🔗 Mi perfil GitHub: {perfilGitHub}");
            Console.WriteLine($"📁 Este repositorio: {repositorio}");
            Console.WriteLine($"⭐ Dale una estrella: {starRepo}");
            Console.WriteLine("");
            
            Console.WriteLine("📱 LINKS PARA REDES SOCIALES:");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            MostrarLinkCompartirTwitter(repositorio);
            MostrarLinkCompartirLinkedIn(repositorio);
            
            Console.WriteLine("");
            Console.WriteLine("✨ ¡Gracias por visitar mi perfil! ✨");
        }
        
        private void MostrarLinkCompartirTwitter(string repositorio)
        {
            string texto = "¡Mira estos ejercicios de C# que he creado!";
            string twitterLink = $"https://twitter.com/intent/tweet?text={Uri.EscapeDataString(texto)}&url={Uri.EscapeDataString(repositorio)}";
            Console.WriteLine($"🐦 Compartir en Twitter: {twitterLink}");
        }
        
        private void MostrarLinkCompartirLinkedIn(string repositorio)
        {
            string linkedinLink = $"https://www.linkedin.com/sharing/share-offsite/?url={Uri.EscapeDataString(repositorio)}";
            Console.WriteLine($"💼 Compartir en LinkedIn: {linkedinLink}");
        }
        
        public void GenerarCodigoQR()
        {
            Console.WriteLine("");
            Console.WriteLine("📱 CÓDIGO QR (ASCII) - MI PERFIL:");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine("█▀▀▀▀▀█ ▀▄█▄  █▀▀▀▀▀█");
            Console.WriteLine("█ ███ █ ▀ ▀▄▀ █ ███ █");
            Console.WriteLine("█ ▀▀▀ █ █▄▀▄█ █ ▀▀▀ █");
            Console.WriteLine("▀▀▀▀▀▀▀ █▄▀ █ ▀▀▀▀▀▀▀");
            Console.WriteLine("██▄ ▄█▀▄▀██▄▀▀██▄▄▀▄▄");
            Console.WriteLine("▀▀ ▀▀ ▀ ▀▀▀▀▀ ▀▀▀▀▀▀▀");
            Console.WriteLine($"Escaneame para ir a: https://github.com/{NombreUsuario}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear instancia del perfil
            PerfilDesarrollador perfil = new PerfilDesarrollador();
            
            // Configurar información del desarrollador
            perfil.NombreUsuario = "FernandoD162003";
            perfil.Nombre = "Fernando D.";
            perfil.Especialidad = "Desarrollador C# - Ejercicios de Programación";
            
            // Mostrar banner de bienvenida
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║        GENERADOR DE LINKS DE PERFIL    ║");
            Console.WriteLine("║             Fernando D. - 2024         ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.WriteLine("");
            
            // Generar y mostrar todos los links
            perfil.MostrarLinksCompartir();
            perfil.GenerarCodigoQR();
            
            Console.WriteLine("");
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}