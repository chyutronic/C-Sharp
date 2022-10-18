using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    internal class Venta
    {
        private int cantidad;
        private string detalle;
        private int total;
        private string medioPago;


        public Venta(int cantidad, string detalle, int total, string medioPago)
        {
            this.cantidad = cantidad;
            this.detalle = detalle;
            this.total = total;
            this.medioPago = medioPago;
        }

        public void SetCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public void SetDetalle(string detalle)
        {
            this.detalle = detalle;
        }

        public void SetTotal(int total)
        {
            this.total = total;
        }

        public void SetMedioPago(string medioPago)
        {
            this.medioPago = medioPago;
        }

        public int GetCantidad()
        {
            return cantidad;
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


    }//fin clase Venta

}//fin namespace PuntoDeVenta


