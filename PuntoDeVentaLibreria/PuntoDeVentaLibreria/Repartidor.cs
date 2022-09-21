using PuntoDeVentaLibreria.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaLibreria
{
    internal class Repartidor : Persona
    {

        string nombreTabla = "Repartidor";

        //private int idRepartidor;
        //private static int idRepartidorSiguiente = 10;


        public Repartidor(string nombre, string apellido, string mail, int telefono) : base(nombre, apellido, mail, telefono)
        {

            //idRepartidor = idRepartidorSiguiente;
            //idRepartidorSiguiente += 10;


        }//fin constructor


        public Repartidor() { }//fin constructor2


        /*public int GetIdRepartidor()
        {
            return idRepartidor;
        }*/



        //métodos para registrar y listar en BD
        ConexionBD conn = new ConexionBD();

        public bool registrarRepartidorBD()
        {
            string sql = "INSERT INTO Repartidor VALUES ('" + this.GetNombre() + "', '" + this.GetApellido() + "', '" + this.GetMail() + "', '" + this.GetTelefono() + "')";
            if (conn.guardarSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void listarRepartidorBD()
        {
            foreach (DataRow item in conn.listarSql(nombreTabla).Rows)
            {
                Console.WriteLine(item["Id_repartidor"].ToString() + " - " + item["Nombre"].ToString() + " - " + item["Apellido"].ToString() + " - " + item["Mail"].ToString() + " - " + item["Telefono"].ToString());
            }

        }


    }//fin class Repartidor 

}//fin namespace PuntoDeVentaLibreria
