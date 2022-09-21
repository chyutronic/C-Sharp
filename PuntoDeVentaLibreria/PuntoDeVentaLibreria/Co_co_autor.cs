using PuntoDeVentaLibreria.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaLibreria
{
    internal class Co_co_autor : Persona
    {

        string nombreTabla = "Co_co_autor";
        int Id_co_autor;

        //private int idCoCoAutor;
        //private static int idCoCoAutorSiguiente = 10;


        public Co_co_autor(string nombre, string apellido, string mail, int telefono, int id_co_autor) : base(nombre, apellido, mail, telefono)
        {

            this.Id_co_autor = id_co_autor;

            //idCoCoAutor = idCoCoAutorSiguiente;
            //idCoCoAutorSiguiente += 10;


        }//fin constructor


        public Co_co_autor() { }//fin constructor2


        /*public int GetIdCoCoAutor()
        {
            return idCoCoAutor;
        }*/



        //métodos para registrar y listar en BD

        ConexionBD conn = new ConexionBD();


        public bool registrarCoCoAutorBD()
        {
            string sql = "INSERT INTO Co_co_autor VALUES ('" + this.GetNombre() + "', '" + this.GetApellido() + "', '" + this.GetMail() + "', '" + this.GetTelefono() + "', '" + this.Id_co_autor + "')";
            if (conn.guardarSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void listarCoCoAutorBD()
        {
            foreach (DataRow item in conn.listarSql(nombreTabla).Rows)
            {
                Console.WriteLine(item["Id_co_co_autor"].ToString() + " - " + item["Nombre"].ToString() + " - " + item["Apellido"].ToString() + " - " + item["Mail"].ToString() + " - " + item["Telefono"].ToString() + " - " + item["Id_co_autor"].ToString());
            }

        }


    }//fin class Co_co_autor

}//fin namespace PuntoDeVentaLibreria

