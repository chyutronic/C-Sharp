using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaLibreria
{
    internal class Co_autor : Persona
    {

        private int idCoAutor;
        private static int idCoAutorSiguiente = 10;


        public Co_autor(string nombre, string apellido, string mail, int telefono) : base(nombre, apellido, mail, telefono)
        {

            idCoAutor = idCoAutorSiguiente;
            idCoAutorSiguiente += 10;


        }//fin constructor


        public int GetIdCoAutor()
        {
            return idCoAutor;
        }


    }//fin class Autor_adicional

}//fin namespace PuntoDeVentaLibreria
