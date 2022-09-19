using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaLibreria
{
    internal class Rep_legal : Persona
    {

        private int idRepLegal;
        private static int idRepLegalSiguiente = 10;


        public Rep_legal(string nombre, string apellido, string mail, int telefono) : base(nombre, apellido, mail, telefono)
        {

            idRepLegal = idRepLegalSiguiente;
            idRepLegalSiguiente += 10;


        }//fin constructor


        public int GetIdRepLegal()
        {
            return idRepLegal;
        }



    }//fin class Rep_legal

}//fin namespace PuntoDeVentaLibreria
