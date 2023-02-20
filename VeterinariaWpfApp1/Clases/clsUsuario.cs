using System; 

namespace VeterinariaWpfApp1.Clases
{
    public class clsUsuario
    {
        #region Atributos
        private int identificador;
        private String usuario, clave;
        #endregion

        #region Constructores
        public clsUsuario()
        {
            this.identificador = 0;
            this.usuario = "";
            this.clave = ""; 
        }

        public clsUsuario(String usu, String cla)
        { 
            this.usuario = usu;
            this.clave = cla; 
        }
        #endregion

        #region Metodos
        public int Identificador
        {
            set { identificador = value; }
            get { return identificador; }
        }
        public String Usuario
        {
            set { usuario = value.ToUpper(); }
            get { return usuario; }
        }
        public String Clave
        {
            set { clave = value.ToUpper(); }
            get { return clave; }
        }
        #endregion

        #region Funciones y Procedimientos
        public String imprimirDatos()
        {
            string dato = "";
            dato = " Sintomas: " + this.usuario + "\n" +
                   " Diagnostico: " + this.clave;
            return dato;
        }
        #endregion
    }
}
