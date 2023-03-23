using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VeterinariaWpfApp.Clases;
using VeterinariaWpfApp1.Bases_de_Datos;

namespace VeterinariaWpfApp1.Datos
{
    public class dtoPropietario
    {
        private ConnSQL conn = new ConnSQL();//para hacer consultas SQL
        private string _SQLConnection = Conn.GetConnectionStrings();

        public bool insertarPropietario(clsPropietario propietario)
        {
            try
            {
                string insertar = "INSERT INTO [VETERINARIASOS].[dbo].[VT_PROPIETARIOS] " +
                    " VALUES ('" + propietario.NumeroIdentificacion + "', '" + propietario.PrimerNombre + "', " +
                    " '" + propietario.SegundoNombre + "','" + propietario.PrimerApellido + "','" + propietario.SegundoApellido + "', " +
                    " '" + propietario.TelefonoCelular + "', '" + propietario.CorreoElectronico + "', " +
                    " '" + propietario.AdicionadoPor + "', CONVERT(DATETIME,'" + propietario.FechaAdicion + "',103), null, null)";
                conn.SQLExecuteCmm(_SQLConnection, insertar);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public clsPropietario consultarPopietario(string identificacion)
        {
            clsPropietario resultado = new clsPropietario();

            string consulta = "SELECT PRO_ID, PRO_IDENTIFICACION, PRO_PRIMER_NOMBRE, " +
                " PRO_PRIMER_APELLIDO, PRO_SEGUNDO_APELLIDO, PRO_TELEFONO, PRO_CORREO " +
                " FROM [VETERINARIASOS].[dbo].[VT_PROPIETARIOS] " +
                " WHERE PRO_IDENTIFICACION ='" + identificacion + "'";
            var respuesta = conn.SQLCargaDataTable(_SQLConnection, consulta, null);
            if (respuesta.Rows.Count > 0)
            {
                for (int i = 0; i < respuesta.Rows.Count; i++)
                {
                    resultado.Identificador = Convert.ToInt16(respuesta.Rows[i].ItemArray[0]);
                    resultado.NumeroIdentificacion = respuesta.Rows[i].ItemArray[1].ToString();
                    resultado.PrimerNombre = respuesta.Rows[i].ItemArray[2].ToString();
                    resultado.PrimerApellido = respuesta.Rows[i].ItemArray[3].ToString();
                    resultado.SegundoApellido = respuesta.Rows[i].ItemArray[4].ToString();
                    resultado.TelefonoCelular = respuesta.Rows[i].ItemArray[5].ToString();
                    resultado.CorreoElectronico = respuesta.Rows[i].ItemArray[6].ToString();
                }
            }
            return resultado;
        }

        public bool actualizarPropietario(clsPropietario propietario)
        {
            try
            {
                string actualizar = "UPDATE [VETERINARIASOS].[dbo].[VT_PROPIETARIOS] " +
                    " SET PRO_PRIMER_NOMBRE = '" + propietario.PrimerNombre + "', " +
                    " PRO_PRIMER_APELLIDO = '" + propietario.PrimerApellido + "', " +
                    " PRO_SEGUNDO_APELLIDO = '" + propietario.SegundoApellido + "', " +
                    " PRO_TELEFONO = '" + propietario.TelefonoCelular + "', " +
                    " PRO_CORREO = '" + propietario.CorreoElectronico + "', " +
                    " PRO_MODIFICADO_POR = '" + propietario.ModificadoPor + "', " +
                    " PRO_FECHA_MODIFICACION = CONVERT(DATETIME,'" + propietario.FechaModificacion + "',103)" +
                    " WHERE PRO_ID = " + propietario.Identificador;
                conn.SQLExecuteCmm(_SQLConnection, actualizar);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
    }
}
