using PuntoDeVentaLibreria.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaLibreria
{
    internal class Nota_credito
    {
        string nombreTabla = "Nota_credito";

        private string detalle;
        private string fecha;
        private string observaciones;
        private int Id_venta;


        public Nota_credito(string detalle, string fecha, string observaciones, int id_venta)
        {
            this.detalle = detalle;
            this.fecha = fecha;
            this.observaciones = observaciones;
            this.Id_venta = id_venta;
        }


        public Nota_credito() { }//fin constructor 2



        public string DETALLE { get => detalle; set => detalle = value; }
        public string FECHA { get => fecha; set => fecha = value; }
        public string OBSERVACIONES { get => observaciones; set => observaciones = value; }
        public int ID_VENTA { get => Id_venta; set => Id_venta = value; }



        //métodos para registrar y listar en BD
        ConexionBD conn = new ConexionBD();

        public bool registrarNotaCreditoBD()
        {
            string sql = "INSERT INTO Nota_credito VALUES ('" + this.detalle + "', '" + this.fecha + "', '" + this.observaciones + "', '" + this.Id_venta + "')";
            if (conn.guardarSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void listarNotaCreditoBD()
        {
            foreach (DataRow item in conn.listarSql(nombreTabla).Rows)
            {
                Console.WriteLine(item["Id_nota_credito"].ToString() + " - " + item["Detalle"].ToString() + " - " + item["Fecha"].ToString() + " - " + item["Observaciones"].ToString() + " - " + item["Id_venta"].ToString());
            }

        }


    }//fin class Nota_credito

}//fin namespace PuntoDeVentaLibreria
