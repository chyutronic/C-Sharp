using PuntoDeVentaLibreria.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaLibreria
{
    internal class Venta
    {

        private string nombreTabla = "Venta";

        private int monto;
        private string fecha;
        private string detalle;
        private string medioPago;
        private int Id_libro;
        private int Id_libreria;
        private int Id_vendedor;



        public Venta(int monto, string fecha, string detalle, string medioPago, int id_libro, int id_libreria, int id_vendedor)
        {
            this.monto = monto;
            this.fecha = fecha;
            this.detalle = detalle;
            this.medioPago = medioPago;
            this.Id_libro = id_libro;
            this.Id_libreria = id_libreria;
            this.Id_vendedor = id_vendedor;
            //private int idVenta;
            //private static int idVentaSiguiente = 10;

        }//fin constructor


        public Venta() { }//fin constructor2



        //métodos getters y setters

        public int MONTO { get => monto; set => monto = value; }
        public string FECHA { get => fecha; set => fecha = value; }
        public string DETALLE { get => detalle; set => detalle = value; }
        public string MEDIO_PAGO { get => medioPago; set => medioPago = value; }
        public int ID_LIBRO { get => Id_libro; set => Id_libro = value; }
        public int ID_LIBRERIA { get => Id_libreria; set => Id_libreria = value; }
        public int ID_VENDEDOR { get => Id_vendedor; set => Id_vendedor = value; }




        //métodos para registrar y listar en BD
        ConexionBD conn = new ConexionBD();

        public bool registrarVentaBD()
        {
            string sql = "INSERT INTO Venta VALUES ('" + this.monto + "', '" + this.fecha + "', '" + this.detalle + "', '" + this.medioPago + "', '" + this.Id_libro + "', '" + this.Id_libreria + "', '" + this.Id_vendedor + "')";
            if (conn.guardarSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void listarVentaBD()
        {
            foreach (DataRow item in conn.listarSql(nombreTabla).Rows)
            {
                Console.WriteLine(item["Id_venta"].ToString() + " - " + item["Monto"].ToString() + " - " + item["Fecha"].ToString() + " - " + item["Detalle"].ToString() + " - " + item["Medio_pago"].ToString() + " - " + item["Id_libro"].ToString() + " - " + item["Id_libreria"].ToString() + " - " + item["Id_vendedor"].ToString());
            }

        }


    }//fin class Venta

}//fin namespace PuntoDeVentaLibreria
