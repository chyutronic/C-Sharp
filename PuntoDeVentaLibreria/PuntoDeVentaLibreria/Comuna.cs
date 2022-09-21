using PuntoDeVentaLibreria.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaLibreria
{
    internal class Comuna
    {
        private string nombreTabla = "Comuna";
        private string nomComuna;
        private int idComuna;
        //private static int idComunaSiguiente = 10;


        public Comuna(string nom_Comuna)
        {
            this.nomComuna = nom_Comuna;
            //idComuna = idComunaSiguiente;
            //idComunaSiguiente += 10;

        }//fin constructor


        public Comuna() { }//fin constructor 2



        public string NOM_COMUNA { get => nomComuna; set => nomComuna = value; }
        public int ID_COMUNA { get => idComuna; set => idComuna = value; }


        ConexionBD conn = new ConexionBD();


        public bool registrarComunaBD()
        {
            string sql = "INSERT INTO Comuna VALUES ('"+this.nomComuna+"')";
            if (conn.guardarSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void listarComunasBD()
        {
            foreach(DataRow item in conn.listarSql(nombreTabla).Rows)
            {
                Console.WriteLine(item["Id_comuna"].ToString() + " - " + item["Comuna"].ToString());
            }

        }



    }//fin class Comuna
}//fin namespace PuntoDeVentaLibreria
