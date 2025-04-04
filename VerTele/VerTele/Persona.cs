using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerTele
{
    internal class Persona
    {
        private string nombre;
        private string domicilio;

        public Persona(string nombre, string domicilio)
        {
            this.nombre = nombre;
            this.domicilio = domicilio;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }

        public override string ToString()
        {
            return "Nombre: " + nombre + " Domicilio: " + domicilio;
        }
    }
}
