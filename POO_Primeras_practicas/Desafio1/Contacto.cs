using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Contacto
    {
        private string nombre;
        private string apellido;
        private string direccion;

        public Contacto(string nombre, string apellido, string direccion) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
        }
        //sobrecargando el constructor para poder instanciar la clase creando un obj vacio
        public Contacto() { }
        public string Nombre {
           get { return nombre; }
           set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Direccion {
            get { return direccion; }
            set { direccion = value; }
        }

        public string MostrarContacto()
        {
            if (this.nombre != null && this.apellido != null && this.direccion != null)
            {
                return "Nombre: " + this.nombre + " Apellido: " + this.apellido + " Direccion: " + this.direccion;
            }
            else if (this.nombre == null || this.apellido == null || this.direccion == null) {
                return "No se puede mostrar el contacto, faltan datos";
            }
            else
            {
                return "No se puede mostrar el contacto";
            }
        
        }
    }
}
