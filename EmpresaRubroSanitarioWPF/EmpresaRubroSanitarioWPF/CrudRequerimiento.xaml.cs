using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MessageBox = System.Windows.Forms.MessageBox;

namespace EmpresaRubroSanitarioWPF
{
    /// <summary>
    /// Lógica de interacción para CrudRequerimiento.xaml
    /// </summary>
    public partial class CrudRequerimiento : Page
    {
        public CrudRequerimiento()
        {
            InitializeComponent();
            BtnEliminarReq.IsEnabled = false;
            BtnActualizarReq.IsEnabled = false;
            CargarCB();

            cbEstado.Items.Add("Resuelto");
            cbEstado.Items.Add("Pendiente");

        }


        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);

        public int IdRequerimiento;


        void CargarCB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Apellido FROM Usuarios", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbResponsable.Items.Add(dr["Apellido"].ToString());
            }
            con.Close();

            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT Tipo_req FROM Tipo_requerimiento", con);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                cbTipoRequerimiento.Items.Add(dr2["Tipo_req"].ToString());
            }
            con.Close();

            con.Open();
            SqlCommand cmd3 = new SqlCommand("SELECT Prioridad FROM Prioridad", con);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                cbPrioridad.Items.Add(dr3["Prioridad"].ToString());
            }
            con.Close();
        }


        private void Regresar(object sender, RoutedEventArgs e)
        {
            Content = new ListaRequerimientos();
        }


        private void CrudCrearRequerimiento(object sender, RoutedEventArgs e)
        {
            if (tbDescripcion.Text == "" || cbEstado.Text == "" || cbTipoRequerimiento.Text == "" || cbPrioridad.Text == "" || cbResponsable.Text == "")
            {
                MessageBox.Show("Los campos no pueden quedar vacíos..!");
            }
            else
            {
                con.Open();
                
                SqlCommand cmd = new SqlCommand("SELECT Id_tipo_req FROM Tipo_requerimiento WHERE Tipo_req = '"+cbTipoRequerimiento.Text+"'", con);
                object valor = cmd.ExecuteScalar();
                int tipoRequerimiento = (int)valor;

                SqlCommand cmd2 = new SqlCommand("SELECT Id_prioridad FROM Prioridad WHERE Prioridad = '" + cbPrioridad.Text + "'", con);
                object valor2 = cmd2.ExecuteScalar();
                int prioridad = (int)valor2;

                SqlCommand cmd3 = new SqlCommand("SELECT Id_usuario FROM Usuarios WHERE Apellido = '" + cbResponsable.Text + "'", con);
                object valor3 = cmd3.ExecuteScalar();
                int usuario = (int)valor3;


                SqlCommand com = new SqlCommand("INSERT INTO Requerimiento VALUES (@descripcion, @estado, @tipoRequerimiento, @prioridad, @usuario);", con);
                com.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = tbDescripcion.Text;
                com.Parameters.Add("@estado", SqlDbType.VarChar).Value = cbEstado.Text;
                com.Parameters.Add("@tipoRequerimiento", SqlDbType.Int).Value = tipoRequerimiento;
                com.Parameters.Add("@prioridad", SqlDbType.Int).Value = prioridad;
                com.Parameters.Add("@usuario", SqlDbType.Int).Value = usuario;

                com.ExecuteNonQuery();
                Content = new ListaRequerimientos();
                con.Close();

                if(prioridad == 10)
                {
                    MessageBox.Show("El requerimiento fue ingresado, tiene un plazo de 3 días", "Confirmación y plazo requerimiento", (MessageBoxButtons)MessageBoxButton.OK, MessageBoxIcon.Information);
                }
                else if(prioridad == 20)
                {
                    MessageBox.Show("El requerimiento fue ingresado, tiene un plazo de 4 días", "Confirmación y plazo requerimiento", (MessageBoxButtons)MessageBoxButton.OK, MessageBoxIcon.Information);
                }
                else if (prioridad == 30)
                {
                    MessageBox.Show("El requerimiento fue ingresado, tiene un plazo de 5 días", "Confirmación y plazo requerimiento", (MessageBoxButtons)MessageBoxButton.OK, MessageBoxIcon.Information);
                }

            }
        }

        
        public void ConsultarReq()
        {
            con.Open();
            SqlCommand com = new SqlCommand("SELECT Descripcion, Requerimiento.Estado, Tipo_req, Prioridad.Prioridad, Apellido FROM Requerimiento INNER JOIN Tipo_requerimiento ON Requerimiento.Id_tipo_req = Tipo_requerimiento.Id_tipo_req INNER JOIN Prioridad ON Requerimiento.Id_prioridad = Prioridad.Id_prioridad INNER JOIN Usuarios ON Requerimiento.Id_usuario = Usuarios.Id_usuario WHERE Id_requerimiento=" + IdRequerimiento + "", con);
            SqlDataReader rdr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            rdr.Read();
            this.tbDescripcion.Text = rdr["Descripcion"].ToString();
            this.cbEstado.SelectedItem = rdr["Estado"].ToString();
            this.cbTipoRequerimiento.SelectedItem = rdr["Tipo_req"];
            this.cbPrioridad.SelectedItem = rdr["Prioridad"];
            this.cbResponsable.SelectedItem = rdr["Apellido"];
            rdr.Close();
            con.Close();

        }


        private void CrudEliminarRequerimiento(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Requerimiento WHERE Id_requerimiento=" + IdRequerimiento + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Content = new ListaRequerimientos();
        }


        private void CrudActualizarRequerimiento(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Requerimiento SET Estado='" + cbEstado.Text + "'  WHERE Id_requerimiento=" + IdRequerimiento + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Content = new ListaRequerimientos();

        }
    }
}
