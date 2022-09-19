using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaLibreria
{
    internal class Repartidor : Persona
    {

        private int idRepartidor;
        private static int idRepartidorSiguiente = 10;


        public Repartidor(string nombre, string apellido, string mail, int telefono) : base(nombre, apellido, mail, telefono)
        {

            idRepartidor = idRepartidorSiguiente;
            idRepartidorSiguiente += 10;


        }//fin constructor


        public int GetIdRepartidor()
        {
            return idRepartidor;
        }



    }//fin class Repartidor 

}//fin namespace PuntoDeVentaLibreria
