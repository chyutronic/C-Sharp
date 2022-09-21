using PuntoDeVentaLibreria.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaLibreria
{
    internal class Co_autor : Persona
    {

        string nombreTabla = "Co_autor";
        int Id_autor;

        //private int idCoAutor;
        //private static int idCoAutorSiguiente = 10;


        public Co_autor(string nombre, string apellido, string mail, int telefono, int id_autor) : base(nombre, apellido, mail, telefono)
        {

            this.Id_autor = id_autor;

            //idCoAutor = idCoAutorSiguiente;
            //idCoAutorSiguiente += 10;


        }//fin constructor


        public Co_autor() { }//fin constructor2


        /*public int GetIdCoAutor()
        {
            return idCoAutor;
        }*/



        //métodos para registrar y listar en BD

        ConexionBD conn = new ConexionBD();


        public bool registrarCoAutorBD()
        {
            string sql = "INSERT INTO Co_autor VALUES ('" + this.GetNombre() + "', '" + this.GetApellido() + "', '" + this.GetMail() + "', '" + this.GetTelefono() + "', '" + this.Id_autor + "')";
            if (conn.guardarSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void listarCoAutorBD()
        {
            foreach (DataRow item in conn.listarSql(nombreTabla).Rows)
            {
                Console.WriteLine(item["Id_co_autor"].ToString() + " - " + item["Nombre"].ToString() + " - " + item["Apellido"].ToString() + " - " + item["Mail"].ToString() + " - " + item["Telefono"].ToString() + " - " + item["Id_autor"].ToString());
            }

        }


    }//fin class Autor_adicional

}//fin namespace PuntoDeVentaLibreria
