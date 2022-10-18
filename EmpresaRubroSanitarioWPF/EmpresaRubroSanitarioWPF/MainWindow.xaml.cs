using System;
using System.Collections.Generic;
using System.Data;
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
using Capa_Entidad;
using Capa_Negocio;
using Application = System.Windows.Forms.Application;
using MessageBox = System.Windows.Forms.MessageBox;

namespace EmpresaRubroSanitarioWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        E_Users objeuser = new E_Users();
        N_Users objnuser = new N_Users();
        Principal frm1 = new Principal();

        public static int id_usuario;
        public static string usuario_nombre;
        public static string usuario_apellido;
        public static string categoria;


        void p_logueo()
        {

            DataTable dt = new DataTable();
            objeuser.usuario = tbUsuario.Text;
            objeuser.clave = tbContrasena.Password.ToString();

            dt = objnuser.N_user(objeuser);


            if(dt.Rows.Count > 0)
            {
                //MessageBox.Show("Bienvenido" + " " + dt.Rows[0][0].ToString() + dt.Rows[0][1].ToString(), "Bienvenida..!", (MessageBoxButtons)MessageBoxButton.OK, MessageBoxIcon.Information);
                usuario_nombre = dt.Rows[0][0].ToString();
                usuario_apellido = dt.Rows[0][1].ToString();
                categoria = dt.Rows[0][4].ToString();
                id_usuario = (int)dt.Rows[0][5];


                frm1.ShowDialog();

                MainWindow login = new MainWindow();
                login.ShowDialog();

                if(login.DialogResult == DialogResult)
                {
                    Application.Run(new Principal());

                }

                tbUsuario.Clear();
                tbContrasena.Clear();

            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta..!", "Mensaje", (MessageBoxButtons)MessageBoxButton.OK, MessageBoxIcon.Information);
            }

        }


        public MainWindow()
        {

            InitializeComponent();

        }


        private void BtnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }


        private void BtnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void btLogin_Click(object sender, RoutedEventArgs e)
        {
            p_logueo();

        }
    }
}
