using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaLibreria
{
    internal class Libreria
    {

        private readonly string nombre;
        private readonly string direccion;
        //private int idLibreria;
        //private static int idLibreriaSiguiente = 10;


        public Libreria(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            //idLibreria = idLibreriaSiguiente;
            //idLibreriaSiguiente += 10;

        }//fin constructor


        //métodos getters
        public string GetNombre()
        {
            return nombre;
        }


        public string GetDireccion()
        {
            return direccion;
        }


        /*public int GetIdLibreria()
        {
            return idLibreria;
        }*/






    }//fin class Libreria

}//fin namespace PuntoDeVentaLibreria
