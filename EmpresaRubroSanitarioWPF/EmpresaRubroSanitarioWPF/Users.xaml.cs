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
    /// Lógica de interacción para Users.xaml
    /// </summary>
    public partial class Users : UserControl
    {
        public Users()
        {
            InitializeComponent();
            CargarDatos();

        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);


        void CargarDatos()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Id_usuario, Nombre, Apellido, Usuario, Categoria FROM Usuarios", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridDatos.ItemsSource = dt.DefaultView;
            con.Close();

        }


        private void BtnCrearUsuario_Click(object sender, RoutedEventArgs e)
        {

            CrudUsuarios ventana = new CrudUsuarios();
            FrameUsuario.Content = ventana;

        }


        private void Eliminar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrudUsuarios ventana = new CrudUsuarios();
            ventana.IdUsuario = id;
            ventana.Consultar();
            FrameUsuario.Content = ventana;
            ventana.Titulo.Text = "E L I M I N A R   U S U A R I O";
            ventana.tbNombreCrud.IsEnabled = false;
            ventana.tbApellidoCrud.IsEnabled = false;
            ventana.tbUsuarioCrud.IsEnabled = false;
            ventana.tbClaveCrud.IsEnabled = false;
            ventana.cbPrivilegio.IsEnabled = false;

            ventana.BtnEliminar.IsEnabled = true;
            ventana.BtnCrear.IsEnabled = false;

        }
    }
}
