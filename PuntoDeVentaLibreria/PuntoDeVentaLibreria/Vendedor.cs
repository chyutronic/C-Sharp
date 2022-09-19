using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaLibreria
{
    internal class Vendedor : Persona
    {

        private int idVendedor;
        private static int idVendedorSiguiente = 10;


        public Vendedor(string nombre, string apellido, string mail, int telefono) : base(nombre, apellido, mail, telefono)
        {

            idVendedor = idVendedorSiguiente;
            idVendedorSiguiente += 10;


        }//fin constructor

        public int GetIdVendedor()
        {
            return idVendedor;
        }

    }//fin class Vendedor

}//fin namespace PuntoDeVentaLibreria
