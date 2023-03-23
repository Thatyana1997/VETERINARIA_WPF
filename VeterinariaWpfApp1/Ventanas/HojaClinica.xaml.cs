using Microsoft.SqlServer.Server;
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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VeterinariaWpfApp.Clases;
using VeterinariaWpfApp1.Datos;
using VeterinariaWpfApp1.Utilidades;

namespace VeterinariaWpfApp1.Ventanas
{
    /// <summary>
    /// Lógica de interacción para HolaClinica.xaml
    /// </summary>
    public partial class HojaClinica : Window
    {
        private List<TextBox> listaCampos = new List<TextBox>();
        dtoMascota masc = new dtoMascota();
        int idMascota = 0;
        NumberFormatInfo formato = new CultureInfo("es-CR").NumberFormat;
        public HojaClinica()
        {
            InitializeComponent();
            lblUsuConectado.Content = variablesGlobales.usuariologin;
            txtFechaAtencion.Text = System.DateTime.Now.ToString("dd/MM/yyyy");
            //
            listaCampos.Add(txtIdentificador);
            listaCampos.Add(txtNombreMascota);
            listaCampos.Add(txtPesoMascota);
            listaCampos.Add(txtSexo);
            listaCampos.Add(txtFechaNacimiento);
            listaCampos.Add(txtAlergias);
            listaCampos.Add(txtSintomas);
            listaCampos.Add(txtDiagnostico);
            listaCampos.Add(txtTratamiento);
            listaCampos.Add(txtAdicionadoPor);
            listaCampos.Add(txtFechaAdicion);
            listaCampos.Add(txtModificadoPor);
            listaCampos.Add(txtFechaModificacion);
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            AgregarMascota ventana = new AgregarMascota();
            ventana.ShowDialog();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            idMascota = 0;
            util.limpiarCampos(listaCampos);
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            clsMascota mascota = masc.buscarMascotaPorIdentificador(txtIdentificador.Text);

            if (mascota != null)
            {
                idMascota = mascota.Identificador;
                txtNombreMascota.Text = mascota.Nombre;
                txtPesoMascota.Text = mascota.Peso.ToString();
                if (mascota.Sexo == 'H')
                {
                    txtSexo.Text = "Hembra";
                }
                else
                {
                    txtSexo.Text = "Macho";
                }
                txtFechaNacimiento.Text = mascota.FechaNacimiento.ToString("dd/MM/yyyy");
                txtAlergias.Text = mascota.Alergias;
            }
            else
            {
                MessageBox.Show("No existe una mascota con esa identificación");
            }
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            decimal peso = Convert.ToDecimal(txtPesoMascota.Text.ToString(formato));
            if (txtNombreMascota.Text.Length > 0 && txtPesoMascota.Text.Length > 0 &&
            txtIdentificador.Text.Length > 0 && txtAlergias.Text.Length > 0)
            {
                clsMascota mascota = new clsMascota(idMascota, txtNombreMascota.Text, peso,
                    txtAlergias.Text, lblUsuConectado.Content.ToString(), DateTime.Now);
                if (masc.actualizarMascota(mascota) == true)
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

            dtoHojaClinica hoj = new dtoHojaClinica();

            clsHoja hoja = new clsHoja(0, txtSintomas.Text, txtDiagnostico.Text, txtTratamiento.Text,
                idMascota, txtAdicionadoPor.Text, Convert.ToDateTime(txtFechaAdicion.Text));

            if (hoj.insertarHojaClinica(hoja) == true)
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
