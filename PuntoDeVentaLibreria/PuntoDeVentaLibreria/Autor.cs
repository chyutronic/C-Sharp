using PuntoDeVentaLibreria.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaLibreria
{
    internal class Autor : Persona
    {

        //private int idAutor;
        //private static int idAutorSiguiente = 10;
        string nombreTabla = "Autor";


        public Autor(string nombre, string apellido, string mail, int telefono) : base(nombre, apellido, mail, telefono)
        {

            //idAutor = idAutorSiguiente;
            //idAutorSiguiente += 10;


        }//fin constructor


        public Autor() { }//fin constructor 2



        /*public int GetIdAutor()
        {
            return idAutor;
        }*/



        //métodos para registrar y listar en BD

        ConexionBD conn = new ConexionBD();


        public bool registrarAutorBD()
        {
            string sql = "INSERT INTO Autor VALUES ('" + this.GetNombre() + "', '" + this.GetApellido() + "', '" + this.GetMail() + "', '" + this.GetTelefono() + "')";
            if (conn.guardarSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void listarAutorBD()
        {
            foreach (DataRow item in conn.listarSql(nombreTabla).Rows)
            {
                Console.WriteLine(item["Id_autor"].ToString() + " - " + item["Nombre"].ToString() + " - " + item["Apellido"].ToString() + " - " + item["Mail"].ToString() + " - " + item["Telefono"].ToString());
            }

        }


    }//fin class Autor

}//fin namespace PuntoDeVentaLibreria
