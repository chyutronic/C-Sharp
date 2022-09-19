using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaLibreria
{
    internal class Venta
    {

        private string fecha;
        private string detalle;
        private int total;
        private string medioPago;
        private int idVenta;
        private static int idVentaSiguiente = 10;


        public Venta(string fecha, string detalle, int total, string medioPago)
        {

            this.fecha = fecha;
            this.detalle = detalle;
            this.total = total;
            this.medioPago = medioPago;
            idVenta = idVentaSiguiente;
            idVentaSiguiente += 10;


        }//fin constructor


        //métodos setters


        public void SetFecha(string fecha)
        {
            this.fecha = fecha;
        }

        public void SetDetalle(string detalle)
        {
            this.detalle = detalle;
        }

        public void SetMedioPago(string medioPago)
        {
            this.medioPago = medioPago;
        }


        //métodos getters

        public string GetFecha()
        {
            return fecha;
        }

        public string GetDetalle()
        {
            return detalle;
        }

        public int GetTotal()
        {
            return total;   
        }

        public string GetMedioPago()
        {
            return medioPago;
        }

        public int GetIdVenta()
        {
            return idVenta;
        }



    }//fin class Venta

}//fin namespace PuntoDeVentaLibreria
