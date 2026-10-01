using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimActividad1SergioYLaura
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona persona = new Persona("Laura", 21);
            persona.EsMayorDeEdad();

            Persona p = new Persona("Sergio", 20);
            p.MostrarDatos();

            // Modificar atributos mediante setters/propiedades
            p.Nombre = "Sergio Garcia";
            p.Edad = 25;
            Console.WriteLine("\nDatos tras la modificacion (Dev 1):");
            p.MostrarDatos();

        }
    }
}
