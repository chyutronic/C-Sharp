using PuntoDeVentaLibreria.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaLibreria
{
    internal class Vendedor : Persona
    {

        string nombreTabla = "Vendedor";

        //private int idVendedor;
        //private static int idVendedorSiguiente = 10;


        public Vendedor(string nombre, string apellido, string mail, int telefono) : base(nombre, apellido, mail, telefono)
        {

            //idVendedor = idVendedorSiguiente;
            //idVendedorSiguiente += 10;


        }//fin constructor


        public Vendedor() {}//fin constructor2


        /*public int GetIdVendedor()
        {
            return idVendedor;
        }*/



        //métodos para registrar y listar en BD
        ConexionBD conn = new ConexionBD();

        public bool registrarVendedorBD()
        {
            string sql = "INSERT INTO Vendedor VALUES ('" + this.GetNombre() + "', '" + this.GetApellido() + "', '" + this.GetMail() + "', '" + this.GetTelefono() + "')";
            if (conn.guardarSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void listarVendedorBD()
        {
            foreach (DataRow item in conn.listarSql(nombreTabla).Rows)
            {
                Console.WriteLine(item["Id_vendedor"].ToString() + " - " + item["Nombre"].ToString() + " - " + item["Apellido"].ToString() + " - " + item["Mail"].ToString() + " - " + item["Telefono"].ToString());
            }

        }


    }//fin class Vendedor

}//fin namespace PuntoDeVentaLibreria
