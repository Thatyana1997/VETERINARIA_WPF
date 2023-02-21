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
using VeterinariaWpfApp1.Utilidades;

namespace VeterinariaWpfApp1.Ventanas
{
    /// <summary>
    /// Lógica de interacción para Propietario.xaml
    /// </summary>
    public partial class Propietario : Window
    {
        public Propietario()
        { 
            InitializeComponent();
            lblUsuConectado.Content = variablesGlobales.usuariologin;
        }
        public void modoPantalla()
        {
            if (rbtConsultar.IsChecked == true)
            {
                lblModo.Content = "Modo: Consulta";
            }
            else if (rbtInclusion.IsChecked == true)
            {
                lblModo.Content = "Modo: Incluir";
            }
            else if (rbtModificacion.IsChecked == true)
            {
                lblModo.Content = "Modo: Modificar";
            }
            else
            {
                lblModo.Content = "Modo:";
            }
        }

        private void rbtConsultar_Checked(object sender, RoutedEventArgs e)
        {
            modoPantalla();
        }

        private void rbtInclusion_Checked(object sender, RoutedEventArgs e)
        {
            modoPantalla();
        }

        private void rbtModificacion_Checked(object sender, RoutedEventArgs e)
        {
            modoPantalla();
        }

        private void btnRegresarMenu_Click(object sender, object e)
        {
            this.Close();
        }
    }
}
