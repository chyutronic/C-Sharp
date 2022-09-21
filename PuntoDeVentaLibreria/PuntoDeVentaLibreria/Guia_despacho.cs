using PuntoDeVentaLibreria.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaLibreria
{
    internal class Guia_despacho
    {

        string nombreTabla = "Guia_despacho";

        private string detalle;
        private string fecha;
        private int estado;
        private int id_venta;
        private int id_repartidor;

        //private int idGuiaDespacho;
        //private static int idGuiaDespachoSiguiente = 10;


        public Guia_despacho(string detalle, string fecha, int estado, int id_venta, int id_repartidor)
        {
            this.detalle = detalle;
            this.fecha = fecha;
            this.estado = estado;
            id_venta = id_venta;
            id_repartidor = id_repartidor;

            //idGuiaDespacho = idGuiaDespachoSiguiente;
            //idGuiaDespachoSiguiente += 10;

        }//fin constructor

        public Guia_despacho() { }//fin constructor2



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


        public int ESTADO
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




        //métodos para registrar y listar en BD
        ConexionBD conn = new ConexionBD();

        public bool registrarGuiaDespachoBD()
        {
            string sql = "INSERT INTO Guia_despacho VALUES ('" + this.detalle + "', '" + this.fecha + "', '" + this.estado + "', '" + this.id_venta + "', '" + this.id_repartidor + "')";
            if (conn.guardarSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void listarGuiaDespachoBD()
        {
            foreach (DataRow item in conn.listarSql(nombreTabla).Rows)
            {
                Console.WriteLine(item["Id_guia_despacho"].ToString() + " - " + item["Detalle"].ToString() + " - " + item["Fecha"].ToString() + " - " + item["Estado"].ToString() + " - " + item["Id_venta"].ToString() + " - " + item["Id_repartidor"].ToString());
            }

        }


    }//fin class Guia_despacho.

}//fin namespace PuntoDeVentaLibreria
