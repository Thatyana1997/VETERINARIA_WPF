using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VeterinariaWpfApp1.Bases_de_Datos;
using VeterinariaWpfApp1.Clases;
using VeterinariaWpfApp1.Utilidades;

namespace VeterinariaWpfApp1.Datos
{
    public class dtoUsuario
    {
        private ConnSQL conn = new ConnSQL();//para hacer consultas SQL
        private string _SQLConnection = Conn.GetConnectionStrings();


        public bool validarIngreso(clsUsuario datos)
        {
            try
            {
                string consulta = "SELECT USU_USUARIO FROM VETERINARIASOS.dbo.VT_USUARIOS WHERE USU_USUARIO ='" 
                    + datos.Usuario + "' AND USU_CLAVE = '" + datos.Clave + "'";

                var existe = conn.SQLCargaDataTable(_SQLConnection, consulta, null);
                if (existe.Rows.Count>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

    }
}
