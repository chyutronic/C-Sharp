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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EmpresaRubroSanitarioWPF
{
    /// <summary>
    /// Lógica de interacción para CrudUsuarios.xaml
    /// </summary>
    public partial class CrudUsuarios : Page
    {

        public CrudUsuarios()
        {
            InitializeComponent();
            BtnEliminar.IsEnabled = false;
            CargarCB();
            
        }


        private void Regresar(object sender, RoutedEventArgs e)
        {
            Content = new Users();
        }


        void CargarCB()
        {
            cbPrivilegio.Items.Add("admin");
            cbPrivilegio.Items.Add("usuario");
        }


        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);


        public int IdUsuario;


        private void BtnCrear_Click(object sender, RoutedEventArgs e)
        {
            if(tbNombreCrud.Text == "" || tbApellidoCrud.Text == "" || tbUsuarioCrud.Text == "" || tbClaveCrud.Text == "" || cbPrivilegio.Text == "")
            {
                MessageBox.Show("Los campos no pueden quedar vacíos..!");
            }
            else
            {
                con.Open();

                SqlCommand com = new SqlCommand("INSERT INTO Usuarios VALUES (@nombre, @apellido, @usuario, @clave, @categoria);", con);
                com.Parameters.Add("@nombre", SqlDbType.VarChar).Value = tbNombreCrud.Text;
                com.Parameters.Add("@apellido", SqlDbType.VarChar).Value = tbApellidoCrud.Text;
                com.Parameters.Add("@usuario", SqlDbType.VarChar).Value = tbUsuarioCrud.Text;
                com.Parameters.Add("@clave", SqlDbType.VarChar).Value = tbClaveCrud.Text;
                com.Parameters.Add("@categoria", SqlDbType.VarChar).Value = cbPrivilegio.Text;

                com.ExecuteNonQuery();
                Content = new Users();
                con.Close();
            }
        }


        public void Consultar()
        {
            con.Open();
            SqlCommand com = new SqlCommand("SELECT * FROM Usuarios WHERE Id_usuario="+IdUsuario+"", con);
            SqlDataReader rdr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            rdr.Read();
            this.tbNombreCrud.Text = rdr["Nombre"].ToString();
            this.tbApellidoCrud.Text = rdr["Apellido"].ToString();
            this.tbUsuarioCrud.Text = rdr["Usuario"].ToString();
            this.tbClaveCrud.Text = rdr["Clave"].ToString();
            this.cbPrivilegio.Text = rdr["Categoria"].ToString();
            rdr.Close();
            con.Close();
        }


        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Usuarios WHERE Id_usuario="+IdUsuario+"", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Content = new Users();

        }

    }
}


