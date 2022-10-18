using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace EmpresaRubroSanitarioWPF
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();

        }

        private void Principal_Load(object sender, EventArgs e)
        {

            switch (MainWindow.categoria.Replace(" ", ""))
            {
                case "admin":
                    button1.Enabled = true;
                    button2.Enabled = true;

                    Cargo.Text = "Administrador";

                    break;

                case "usuario":
                    button1.Enabled = false;
                    button2.Enabled = true;

                    Cargo.Text = "Usuario";

                    break;
            }


            Nombre.Text = MainWindow.usuario_nombre;
            Apellido.Text = MainWindow.usuario_apellido;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios ventana = new Usuarios();
            ElementHost.EnableModelessKeyboardInterop(ventana);
            ventana.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Requerimientos ventana = new Requerimientos();
            ElementHost.EnableModelessKeyboardInterop(ventana);
            ventana.Show();
        }
    }
}
