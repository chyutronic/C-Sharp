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
    /// Lógica de interacción para ListaRequerimientos.xaml
    /// </summary>
    public partial class ListaRequerimientos : UserControl
    {
        public ListaRequerimientos()
        {
            InitializeComponent();
            CargarDatos();

            cbTipoRequerimiento.Items.Add("Base de datos");
            cbTipoRequerimiento.Items.Add("Sistemas");
            cbTipoRequerimiento.Items.Add("Servidores");

            cbPrioridad.Items.Add("Alta");
            cbPrioridad.Items.Add("Media");
            cbPrioridad.Items.Add("Baja");

            cbPendienteResuelto.Items.Add("Pendiente");
            cbPendienteResuelto.Items.Add("Resuelto");

        }


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);


        void CargarDatos()
        {

            if(MainWindow.categoria.Replace(" ", "") == "admin")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id_requerimiento, Descripcion, Estado, Tipo_req, Prioridad, Apellido FROM Requerimiento INNER JOIN Tipo_requerimiento ON Requerimiento.Id_tipo_req = Tipo_requerimiento.Id_tipo_req INNER JOIN Prioridad ON Requerimiento.Id_prioridad = Prioridad.Id_prioridad INNER JOIN Usuarios ON Requerimiento.Id_usuario = Usuarios.Id_usuario ORDER BY Id_requerimiento ASC", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridDatos.ItemsSource = dt.DefaultView;
                con.Close();

            }
            else if(MainWindow.categoria.Replace(" ", "") == "usuario")
            {
                cbTipoRequerimiento.IsEnabled = false;
                cbPrioridad.IsEnabled = false;
                cbPendienteResuelto.IsEnabled = false;
                BtnCrearRequerimiento.IsEnabled = false;
                BtnBuscarRequerimiento.IsEnabled = false;
                //BtnEliminar.IsEnabled = false;


                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id_requerimiento, Descripcion, Estado, Tipo_req, Prioridad, Apellido FROM Requerimiento INNER JOIN Tipo_requerimiento ON Requerimiento.Id_tipo_req = Tipo_requerimiento.Id_tipo_req INNER JOIN Prioridad ON Requerimiento.Id_prioridad = Prioridad.Id_prioridad INNER JOIN Usuarios ON Requerimiento.Id_usuario = Usuarios.Id_usuario WHERE Requerimiento.Id_usuario ="+MainWindow.id_usuario+" ORDER BY Id_requerimiento ASC", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridDatos.ItemsSource = dt.DefaultView;
                con.Close();
                
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error. Vuelva a intentarlo..!");
            }

        }


        private void AgregarRequerimiento(object sender, RoutedEventArgs e)
        {
            CrudRequerimiento ventana = new CrudRequerimiento();
            FrameRequerimientos.Content = ventana;
        }


        private void BuscarRequerimiento(object sender, RoutedEventArgs e)
        {
            //Buscador por tipo de requerimiento
            if(cbTipoRequerimiento.Text == "Base de datos")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id_requerimiento, Descripcion, Estado, Tipo_req, Prioridad, Apellido FROM Requerimiento INNER JOIN Tipo_requerimiento ON Requerimiento.Id_tipo_req = Tipo_requerimiento.Id_tipo_req INNER JOIN Prioridad ON Requerimiento.Id_prioridad = Prioridad.Id_prioridad INNER JOIN Usuarios ON Requerimiento.Id_usuario = Usuarios.Id_usuario WHERE Requerimiento.Id_tipo_req = 10 ORDER BY Id_requerimiento ASC", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridDatos.ItemsSource = dt.DefaultView;
                con.Close();
            }
            else if(cbTipoRequerimiento.Text == "Sistemas")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id_requerimiento, Descripcion, Estado, Tipo_req, Prioridad, Apellido FROM Requerimiento INNER JOIN Tipo_requerimiento ON Requerimiento.Id_tipo_req = Tipo_requerimiento.Id_tipo_req INNER JOIN Prioridad ON Requerimiento.Id_prioridad = Prioridad.Id_prioridad INNER JOIN Usuarios ON Requerimiento.Id_usuario = Usuarios.Id_usuario WHERE Requerimiento.Id_tipo_req = 20 ORDER BY Id_requerimiento ASC", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridDatos.ItemsSource = dt.DefaultView;
                con.Close();
            }
            else if (cbTipoRequerimiento.Text == "Servidores")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id_requerimiento, Descripcion, Estado, Tipo_req, Prioridad, Apellido FROM Requerimiento INNER JOIN Tipo_requerimiento ON Requerimiento.Id_tipo_req = Tipo_requerimiento.Id_tipo_req INNER JOIN Prioridad ON Requerimiento.Id_prioridad = Prioridad.Id_prioridad INNER JOIN Usuarios ON Requerimiento.Id_usuario = Usuarios.Id_usuario WHERE Requerimiento.Id_tipo_req = 30 ORDER BY Id_requerimiento ASC", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridDatos.ItemsSource = dt.DefaultView;
                con.Close();
            }

            //buscador por prioridad
            else if(cbPrioridad.Text == "Alta")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id_requerimiento, Descripcion, Estado, Tipo_req, Prioridad, Apellido FROM Requerimiento INNER JOIN Tipo_requerimiento ON Requerimiento.Id_tipo_req = Tipo_requerimiento.Id_tipo_req INNER JOIN Prioridad ON Requerimiento.Id_prioridad = Prioridad.Id_prioridad INNER JOIN Usuarios ON Requerimiento.Id_usuario = Usuarios.Id_usuario WHERE Requerimiento.Id_prioridad = 10 ORDER BY Id_requerimiento ASC", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridDatos.ItemsSource = dt.DefaultView;
                con.Close();

            }
            else if (cbPrioridad.Text == "Media")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id_requerimiento, Descripcion, Estado, Tipo_req, Prioridad, Apellido FROM Requerimiento INNER JOIN Tipo_requerimiento ON Requerimiento.Id_tipo_req = Tipo_requerimiento.Id_tipo_req INNER JOIN Prioridad ON Requerimiento.Id_prioridad = Prioridad.Id_prioridad INNER JOIN Usuarios ON Requerimiento.Id_usuario = Usuarios.Id_usuario WHERE Requerimiento.Id_prioridad = 20 ORDER BY Id_requerimiento ASC", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridDatos.ItemsSource = dt.DefaultView;
                con.Close();

            }
            else if (cbPrioridad.Text == "Baja")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id_requerimiento, Descripcion, Estado, Tipo_req, Prioridad, Apellido FROM Requerimiento INNER JOIN Tipo_requerimiento ON Requerimiento.Id_tipo_req = Tipo_requerimiento.Id_tipo_req INNER JOIN Prioridad ON Requerimiento.Id_prioridad = Prioridad.Id_prioridad INNER JOIN Usuarios ON Requerimiento.Id_usuario = Usuarios.Id_usuario WHERE Requerimiento.Id_prioridad = 30 ORDER BY Id_requerimiento ASC", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridDatos.ItemsSource = dt.DefaultView;
                con.Close();

            }

            //buscador por pendiente / resuelto
            else if(cbPendienteResuelto.Text == "Pendiente")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id_requerimiento, Descripcion, Estado, Tipo_req, Prioridad, Apellido FROM Requerimiento INNER JOIN Tipo_requerimiento ON Requerimiento.Id_tipo_req = Tipo_requerimiento.Id_tipo_req INNER JOIN Prioridad ON Requerimiento.Id_prioridad = Prioridad.Id_prioridad INNER JOIN Usuarios ON Requerimiento.Id_usuario = Usuarios.Id_usuario WHERE Requerimiento.Estado = 'Pendiente' ORDER BY Id_requerimiento ASC", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridDatos.ItemsSource = dt.DefaultView;
                con.Close();

            }
            else if (cbPendienteResuelto.Text == "Resuelto")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id_requerimiento, Descripcion, Estado, Tipo_req, Prioridad, Apellido FROM Requerimiento INNER JOIN Tipo_requerimiento ON Requerimiento.Id_tipo_req = Tipo_requerimiento.Id_tipo_req INNER JOIN Prioridad ON Requerimiento.Id_prioridad = Prioridad.Id_prioridad INNER JOIN Usuarios ON Requerimiento.Id_usuario = Usuarios.Id_usuario WHERE Requerimiento.Estado = 'Resuelto' ORDER BY Id_requerimiento ASC", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridDatos.ItemsSource = dt.DefaultView;
                con.Close();

            }

            cbTipoRequerimiento.SelectedIndex = -1;
            cbPrioridad.SelectedIndex = -1;
            cbPendienteResuelto.SelectedIndex = -1;

            cbPrioridad.IsEnabled = true;
            cbPendienteResuelto.IsEnabled = true;
            cbTipoRequerimiento.IsEnabled = true;

        }


        private void BloquearPyPR(object sender, SelectionChangedEventArgs e)
        {
            cbPrioridad.IsEnabled = false;
            cbPendienteResuelto.IsEnabled = false;
        }


        private void BloquearTRyPR(object sender, SelectionChangedEventArgs e)
        {
            cbTipoRequerimiento.IsEnabled = false;
            cbPendienteResuelto.IsEnabled = false;
        }


        private void BloquearTRyP(object sender, SelectionChangedEventArgs e)
        {
            cbTipoRequerimiento.IsEnabled = false;
            cbPrioridad.IsEnabled = false;
        }


        private void Eliminar(object sender, RoutedEventArgs e)
        {

            if (MainWindow.categoria.Replace(" ", "") == "admin")
            {
                int id = (int)((Button)sender).CommandParameter;
                CrudRequerimiento ventana = new CrudRequerimiento();
                ventana.IdRequerimiento = id;
                ventana.ConsultarReq();
                FrameRequerimientos.Content = ventana;
                ventana.Titulo.Text = "E L I M I N A R   R E Q U E R I M I E N T O";
                ventana.tbDescripcion.IsEnabled = false;
                ventana.cbEstado.IsEnabled = false;
                ventana.cbTipoRequerimiento.IsEnabled = false;
                ventana.cbPrioridad.IsEnabled = false;
                ventana.cbResponsable.IsEnabled = false;

                ventana.BtnEliminarReq.IsEnabled = true;
                ventana.BtnCrearReq.IsEnabled = false;
                ventana.BtnActualizarReq.IsEnabled = false;

            }
            else if (MainWindow.categoria.Replace(" ", "") == "usuario")
            {
                MessageBox.Show("Usted no tiene permiso para eliminar requerimientos..!");
            }

        }


        private void Actualizar(object sender, RoutedEventArgs e)
        {

            int id = (int)((Button)sender).CommandParameter;
            CrudRequerimiento ventana = new CrudRequerimiento();
            ventana.IdRequerimiento = id;
            ventana.ConsultarReq();
            FrameRequerimientos.Content = ventana;
            ventana.Titulo.Text = "A C T U A L I Z A R   R E Q U E R I M I E N T O";
            ventana.tbDescripcion.IsEnabled = false;
            ventana.cbEstado.IsEnabled = true;
            ventana.cbTipoRequerimiento.IsEnabled = false;
            ventana.cbPrioridad.IsEnabled = false;
            ventana.cbResponsable.IsEnabled = false;

            ventana.BtnEliminarReq.IsEnabled = false;
            ventana.BtnCrearReq.IsEnabled = false;
            ventana.BtnActualizarReq.IsEnabled = true;

        }
    }
}
