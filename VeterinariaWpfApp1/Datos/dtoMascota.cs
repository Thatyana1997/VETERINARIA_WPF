using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VeterinariaWpfApp.Clases;
using VeterinariaWpfApp1.Bases_de_Datos;

namespace VeterinariaWpfApp1.Datos
{
    public class dtoMascota
    {
        private ConnSQL conn = new ConnSQL();//para hacer consultas SQL
        private string _SQLConnection = Conn.GetConnectionStrings();
        NumberFormatInfo formato = new CultureInfo("es-CR").NumberFormat;

        public bool insertarMascota(clsMascota mascota)
        {
            try
            {
                string insertar = "INSERT INTO [VETERINARIASOS].[dbo].[VT_MASCOTAS] " +
                    " VALUES ('" + mascota.Nombre + "', CONVERT(DATETIME,'" + mascota.FechaNacimiento + "',103), " +
                    " '" + mascota.Sexo + "', " + mascota.Peso + " ,'" + mascota.Alergias + "', " +
                    " " + mascota.IdentificadorPropietario + ", " +
                    " '" + mascota.AdicionadoPor + "', CONVERT(DATETIME,'" + mascota.FechaAdicion + "',103), null, null)";
                conn.SQLExecuteCmm(_SQLConnection, insertar);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        public string buscarMascotaPorPropietarioNombre(int idPro, string nom)
        {
            string idMascot = "";

            string consulta = "SELECT MAS_ID" +
                " FROM [VETERINARIASOS].[dbo].[VT_MASCOTAS] " +
                " WHERE MAS_PRO_ID = '" + idPro + "' AND MAS_NOMBRE= '" + nom + "'";
            var respuesta = conn.SQLCargaDataTable(_SQLConnection, consulta, null);
            if (respuesta.Rows.Count > 0)
            {
                for (int i = 0; i < respuesta.Rows.Count; i++)
                {
                    idMascot = respuesta.Rows[i].ItemArray[0].ToString();
                    return idMascot;
                }
            }
            return idMascot;
        }

        public clsMascota buscarMascotaPorIdentificador(string idMasc)
        {
            clsMascota resultado = new clsMascota();

            string consulta = "SELECT MAS_ID, MAS_NOMBRE, MAS_PESO, MAS_SEXO, CONVERT(DATE,MAS_FECHA_NACIMIENTO), MAS_ALERGIAS " +
                " FROM [VETERINARIASOS].[dbo].[VT_MASCOTAS] " +
                " WHERE MAS_ID = '" + idMasc + "'";
            var respuesta = conn.SQLCargaDataTable(_SQLConnection, consulta, null);
            if (respuesta.Rows.Count > 0)
            {
                for (int i = 0; i < respuesta.Rows.Count; i++)
                {
                    resultado.Identificador = Convert.ToUInt16(respuesta.Rows[i].ItemArray[0].ToString());
                    resultado.Nombre = respuesta.Rows[i].ItemArray[1].ToString();
                    resultado.Peso = Convert.ToDecimal(respuesta.Rows[i].ItemArray[2].ToString());
                    resultado.Sexo = Convert.ToChar(respuesta.Rows[i].ItemArray[3].ToString());
                    resultado.FechaNacimiento = Convert.ToDateTime(respuesta.Rows[i].ItemArray[4].ToString());
                    resultado.Alergias = respuesta.Rows[i].ItemArray[5].ToString();
                }
            }
            return resultado;
        }

        public bool actualizarMascota(clsMascota mascota)
        {
            try
            {
                string actualizar = "UPDATE [VETERINARIASOS].[dbo].[VT_MASCOTAS] " +
                    " SET  MAS_NOMBRE = '" + mascota.Nombre + "', " +
                    " MAS_PESO = " + mascota.Peso + ", " +
                    " MAS_ALERGIAS = '" + mascota.Alergias + "', " + 
                    " MAS_MODIFICADO_POR = '" + mascota.ModificadoPor + "', " +
                    " MAS_FECHA_MODIFICACION = CONVERT(DATETIME,'" + mascota.FechaModificacion + "',103)" +
                    " WHERE MAS_ID = " + mascota.Identificador;
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
