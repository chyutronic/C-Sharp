using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco
{
    class Usuario
    {
        public string nombre;
        public string apellido;
        public string rut;
        public string direccion;
        public int telefono;


        public Usuario(string nombre, string apellido, string rut, string direccion, int telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.rut = rut;
            this.direccion = direccion;
            this.telefono = telefono;

        }//fin constructor


        public void actualizarDatos(string nuevaDireccion, int nuevoTelefono)
        {
            this.direccion = nuevaDireccion;
            this.telefono = nuevoTelefono;

            Console.WriteLine("Datos actualizados correctamente");
        }


    }//fin class Usuario

}//fin namespace CuentaDeBanco
