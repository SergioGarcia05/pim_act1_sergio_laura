using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimActividad1SergioYLaura
{
    public class Persona
    {
        private string nombre;
        private int edad;

        // Persona.cs (Paso 2)
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        // Persona.cs (Paso 3)
        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {nombre}, Edad: {edad}");
        }
    }
}
