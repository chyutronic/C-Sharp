using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace EmpresaRubroSanitarioWPF
{
    /// <summary>
    /// Lógica de interacción para Requerimientos.xaml
    /// </summary>
    public partial class Requerimientos : Window
    {

        public Requerimientos()
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


        private void BtnRequerimientos_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ListaRequerimientos();
        }
    }
}
