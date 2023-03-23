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
using VeterinariaWpfApp.Clases;
using VeterinariaWpfApp1.Datos;
using VeterinariaWpfApp1.Utilidades;

namespace VeterinariaWpfApp1.Ventanas
{
    /// <summary>
    /// Lógica de interacción para Propietario.xaml
    /// </summary>
    public partial class AgregarPropietario : Window
    {
        private List<TextBox> listaCampos = new List<TextBox>();
        public AgregarPropietario()
        {
            InitializeComponent();
            lblUsuConectado.Content = variablesGlobales.usuariologin;

            //
            listaCampos.Add(txtIdentificacion);
            listaCampos.Add(txtPrimerNombre);
            listaCampos.Add(txtPrimerApellido);
            listaCampos.Add(txtSegundoNombre);
            listaCampos.Add(txtSegundoApellido);
            listaCampos.Add(txtCorreoElectronico);
            listaCampos.Add(txtTelefonoCelular);
            listaCampos.Add(txtAdicionadoPor);
            listaCampos.Add(txtFechaAdicion);
            listaCampos.Add(txtModificadoPor);
            listaCampos.Add(txtFechaModificacion);
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            util.limpiarCampos(listaCampos);
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            txtFechaAdicion.Text = System.DateTime.Now.ToString();
            txtAdicionadoPor.Text = variablesGlobales.usuariologin;

            dtoPropietario prop = new dtoPropietario();

            clsPropietario propietario = new clsPropietario(0, txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text,
                txtSegundoApellido.Text, txtIdentificacion.Text, txtCorreoElectronico.Text, txtTelefonoCelular.Text,
                txtAdicionadoPor.Text, Convert.ToDateTime(txtFechaAdicion.Text));

            if (prop.insertarPropietario(propietario) == true)
            {
                MessageBox.Show("Datos guardados de forma exitosa!");
            }
            else
            {
                MessageBox.Show("No se guardo la información!");
            }
        }
    }
}
