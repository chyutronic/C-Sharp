using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaLibreria
{
    internal class Co_co_autor : Persona
    {

        private int idCoCoAutor;
        private static int idCoCoAutorSiguiente = 10;


        public Co_co_autor(string nombre, string apellido, string mail, int telefono) : base(nombre, apellido, mail, telefono)
        {

            idCoCoAutor = idCoCoAutorSiguiente;
            idCoCoAutorSiguiente += 10;


        }//fin constructor


        public int GetIdCoCoAutor()
        {
            return idCoCoAutor;
        }



    }//fin class Co_co_autor

}//fin namespace PuntoDeVentaLibreria

