using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
using System.Transactions;

namespace PuntoDeVentaLibreria.Conexion
{
    internal class ConexionBD
    {

        string cadenaConexion = @"Data Source=YUTRO-ASUS; Initial Catalog=PuntoDeVentaLibreria; Integrated Security=True; TrustServerCertificate=True";


        private SqlConnection conn;
        private SqlCommand comd;

        //listar en tablas
        private SqlDataAdapter sda;
        private DataTable dtt;
        private DataSet dts;


        private void Conectar()
        {
            conn = new SqlConnection(cadenaConexion);
        }
        

        //Constructor
        public ConexionBD()
        {
            Conectar();

        }

        public bool guardarSql(string sql)
        {
            try 
            { 
                comd = new SqlCommand(sql, conn);
                conn.Open();
                int i = comd.ExecuteNonQuery();
                if(i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } 
            catch(Exception e) 
            {
                throw e;
            } 
            finally 
            {
                conn.Close();    
            }
        }


        public DataTable listarSql(string tabla)
        {
            try 
            {
                string sql = "SELECT * FROM " + tabla;
                conn.Open();
                sda = new SqlDataAdapter(sql, conn);
                dts = new DataSet();
                sda.Fill(dts, tabla);
                dtt = new DataTable();
                dtt = dts.Tables[tabla];
            } 
            catch(Exception e) 
            {
                throw e;
            } 
            finally 
            { 
                conn.Close ();
            }
            return dtt;
        }



    }//fin class ConexionBD
}//fin namespace PuntoDeVentaLibreria
