using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaLibreria
{
    internal class Autor : Persona
    {

        private int idAutor;
        private static int idAutorSiguiente = 10;


        public Autor(string nombre, string apellido, string mail, int telefono) : base(nombre, apellido, mail, telefono)
        {

            idAutor = idAutorSiguiente;
            idAutorSiguiente += 10;


        }//fin constructor


        public int GetIdAutor()
        {
            return idAutor;
        }


    }//fin class Autor

}//fin namespace PuntoDeVentaLibreria
