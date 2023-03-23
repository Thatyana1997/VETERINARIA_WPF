using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VeterinariaWpfApp.Clases;
using VeterinariaWpfApp1.Datos;
using VeterinariaWpfApp1.Utilidades;

namespace VeterinariaWpfApp1.Ventanas
{
    /// <summary>
    /// Lógica de interacción para AgregarMascota.xaml
    /// </summary>
    public partial class AgregarMascota : Window
    {
        private List<TextBox> listaCampos = new List<TextBox>();
        private dtoPropietario prop = new dtoPropietario();
        private int idPropietario = 0;
        NumberFormatInfo formato = new CultureInfo("es-CR").NumberFormat;
        public AgregarMascota()
        {
            InitializeComponent();
            lblUsuConectado.Content = variablesGlobales.usuariologin;
            //
            listaCampos.Add(txtIdentificacion);
            listaCampos.Add(txtPrimerNombre);
            listaCampos.Add(txtPrimerApellido);
            listaCampos.Add(txtSegundoApellido);
            listaCampos.Add(txtCorreoElectronico);
            listaCampos.Add(txtTelefonoCelular);
            listaCampos.Add(txtNombreMascota);
            listaCampos.Add(txtPesoMascota);
            listaCampos.Add(txtAlergias);
            listaCampos.Add(txtAdicionadoPor);
            listaCampos.Add(txtFechaAdicion);
            listaCampos.Add(txtModificadoPor);
            listaCampos.Add(txtFechaModificacion);
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            AgregarPropietario ventana = new AgregarPropietario();
            ventana.ShowDialog();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            idPropietario = 0;
            dpFechanacimiento.SelectedDate = DateTime.Now;
            cmbSexo.SelectedIndex = 0;
            util.limpiarCampos(listaCampos);
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            idPropietario = 0;
            clsPropietario propietario = prop.consultarPopietario(txtIdentificacion.Text);

            if (propietario != null)
            {
                idPropietario = propietario.Identificador;
                txtPrimerNombre.Text = propietario.PrimerNombre;
                txtPrimerApellido.Text = propietario.PrimerApellido;
                txtSegundoApellido.Text = propietario.SegundoApellido;
                txtCorreoElectronico.Text = propietario.CorreoElectronico;
                txtTelefonoCelular.Text = propietario.TelefonoCelular;
            }
            else
            {
                MessageBox.Show("No existe un propietario con esa identificación");
            }
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            if (txtPrimerNombre.Text.Length > 0 && txtPrimerApellido.Text.Length > 0 &&
            txtSegundoApellido.Text.Length > 0 && txtCorreoElectronico.Text.Length > 0 && txtTelefonoCelular.Text.Length > 0)
            {
                clsPropietario propietario = new clsPropietario(idPropietario, txtPrimerNombre.Text, txtPrimerApellido.Text,
                    txtSegundoApellido.Text, txtCorreoElectronico.Text, txtTelefonoCelular.Text,
                    lblUsuConectado.Content.ToString(), DateTime.Now);
                if (prop.actualizarPropietario(propietario) == true)
                {

                    MessageBox.Show("Datos actualizados de forma exitosa!");
                }
                else
                {
                    MessageBox.Show("No se actualizo la información!");
                }
            }
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            txtFechaAdicion.Text = System.DateTime.Now.ToString();
            txtAdicionadoPor.Text = variablesGlobales.usuariologin;
            char sexo;
            decimal peso = Convert.ToDecimal(txtPesoMascota.Text.ToString(formato));

            if (cmbSexo.SelectedIndex == 0)
            {
                sexo = 'H';
            }
            else
            {
                sexo = 'M';
            }

            dtoMascota masc = new dtoMascota();

            clsMascota mascota = new clsMascota(0, txtNombreMascota.Text, dpFechanacimiento.SelectedDate.Value, sexo,
                peso, txtAlergias.Text, idPropietario, txtAdicionadoPor.Text, Convert.ToDateTime(txtFechaAdicion.Text));
            if (masc.insertarMascota(mascota) == true)
            {
                MessageBox.Show("Datos guardados de forma exitosa!");
                txtIdentificador.Text = masc.buscarMascotaPorPropietarioNombre(idPropietario, mascota.Nombre);
            }
            else
            {
                MessageBox.Show("No se guardo la información!");
            }
        }
    }
}
