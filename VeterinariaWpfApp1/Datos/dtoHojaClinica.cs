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
    public class dtoHojaClinica
    {
        private ConnSQL conn = new ConnSQL();//para hacer consultas SQL
        private string _SQLConnection = Conn.GetConnectionStrings();

        public bool insertarHojaClinica(clsHoja hoja)
        {
            try
            {
                string insertar = "INSERT INTO [VETERINARIASOS].[dbo].[VT_HOJA] " +
                    " VALUES ( CONVERT(DATETIME,'" + hoja.FechaAdicion.ToString("dd/MM/yyyy") + "',103), " +
                    " '" + hoja.Sintomas + "', '" + hoja.Diagnostico + "' ,'" + hoja.Tratamiento + "', " +
                    " " + hoja.IdentificadorMascota + ", " +
                    " '" + hoja.AdicionadoPor + "', CONVERT(DATETIME,'" + hoja.FechaAdicion + "',103), null, null)";
                conn.SQLExecuteCmm(_SQLConnection, insertar);
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
