using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaWpfApp.Clases
{
    public class clsPropietario
    {
        #region Atributos
        private int identificador;
        private String primerNombre, segundoNombre, primerApellido, segundoApellido, numeroIdentificacion; 
        private String correoElectronico, telefonoCelular;
        #endregion

        #region Constructores
        public clsPropietario()
        {
            this.identificador = 0;
            this.primerNombre = "";
            this.segundoNombre = "";
            this.primerApellido = "";
            this.segundoApellido = "";
            this.numeroIdentificacion = "";
            this.correoElectronico = "";
            this.telefonoCelular = "";
        }

        public clsPropietario(int iden, String pnom, String snom, String pape, String sape,
                              String nuid, String corr, String tele)
        {
            this.identificador = iden;
            this.primerNombre = pnom;
            this.segundoNombre = snom;
            this.primerApellido = pape;
            this.segundoApellido = sape;
            this.numeroIdentificacion = nuid;
            this.correoElectronico = corr;
            this.telefonoCelular = tele;
        }
        #endregion

        #region Metodos
        public int Identificador
        {
            set { identificador = value; }
            get { return identificador; }
        }
        public String PrimerNombre
        {
            set { primerNombre = value.ToUpper(); }
            get { return primerNombre; }
        }
        public String SegundoNombre
        {
            set { segundoNombre = value.ToUpper(); }
            get { return segundoNombre; }
        }

        public String PrimerApellido
        {
            set { primerApellido = value.ToUpper(); }
            get { return primerApellido; }
        }
        public String SegundoApellido
        {
            set { segundoApellido = value.ToUpper(); }
            get { return segundoApellido; }
        }
        public String NumeroIdentificacion
        {
            set { numeroIdentificacion = value.ToUpper(); }
            get { return numeroIdentificacion; }
        }
        public String CorreoElectronico
        {
            set { correoElectronico = value.ToUpper(); }
            get { return correoElectronico; }
        }
        public String TelefonoCelular
        {
            set { telefonoCelular = value.ToUpper(); }
            get { return telefonoCelular; }
        }
        #endregion

        #region Funciones y Procedimientos
        public String imprimirDatos()
        {
            string dato = "";
            dato = " Nombre Completo: " + this.primerNombre + " " + this.segundoNombre + "\n" + 
                                          this.primerApellido + " " + this.segundoApellido + "\n" +
                   " Numero Identificación: " + this.numeroIdentificacion + "\n" +
                   " Correo Electrónico: " + this.correoElectronico + "\n" +
                   " Teléfono Celular: " + this.telefonoCelular + "\n";
            return dato;
        }
        #endregion
    }
}
