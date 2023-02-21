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
using VeterinariaWpfApp1.Clases;
using VeterinariaWpfApp1.Datos;
using VeterinariaWpfApp1.Utilidades;

namespace VeterinariaWpfApp1.Ventanas
{
    /// <summary>
    /// Lógica de interacción para Ingreso.xaml
    /// </summary>
    public partial class Ingreso : Window
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private void txtUsuario_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Utilidades.util.validarSoloLetras(e);
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsuario.Text.Length > 0 && txtClave.Password.ToString().Length > 0)
            { 
                clsUsuario usuario = new clsUsuario(txtUsuario.Text, txtClave.Password.ToString());
                
                //data transfer object DTO que comunica con la base de datos
                dtoUsuario usu = new dtoUsuario();
                if (usu.validarIngreso(usuario) == true)
                {
                    variablesGlobales.usuariologin = usuario.Usuario;
                    Propietario ventana = new Propietario();
                    ventana.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos!");
                }
            }
            else
            {
                MessageBox.Show("Debes completar los campos de Usuario y Clave");
            }

        }
    }
}
