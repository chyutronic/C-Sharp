using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    internal class Local
    {
        private readonly string nombre;
        private readonly string direccion;


        public Local(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetDireccion()
        {
            return direccion;
        }


    }//fin clase Local
}//fin namespace PuntoDeVenta
