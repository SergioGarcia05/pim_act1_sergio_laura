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
        }
    }
}
