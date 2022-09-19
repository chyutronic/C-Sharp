using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaLibreria
{
    internal class Guia_despacho
    {
        private string detalle;
        private string fecha;
        private bool estado;
        private int id_venta;
        private int id_repartidor;
        private int idGuiaDespacho;
        private static int idGuiaDespachoSiguiente = 10;


        public Guia_despacho(string detalle, string fecha, bool estado, int id_venta, int id_repartidor)
        {
            this.detalle = detalle;
            this.fecha = fecha;
            this.estado = estado;
            id_venta = id_venta;
            id_repartidor = id_repartidor;
            idGuiaDespacho = idGuiaDespachoSiguiente;
            idGuiaDespachoSiguiente += 10;

        }


        public int ID_GUIA_DESPACHO
        {
            get { return idGuiaDespacho; }
        }


        public string DETALLE
        {
            get { return detalle; }
            set { this.detalle = value; }
        }


        public string FECHA
        {
            get { return fecha; }
            set { this.fecha = value; }
        }


        public bool ESTADO
        {
            get { return estado; }
            set { this.estado = value; }
        }


        public int ID_VENTA
        {
            get { return id_venta; }
            set { this.id_venta = value; }
        }


        public int ID_REPARTIDOR
        {
            get { return id_repartidor; }
            set { this.id_repartidor = value; }
        }

    }
}
