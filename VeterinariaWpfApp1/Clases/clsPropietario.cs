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
        private DateTime fechaAdicion, fechaModificacion;
        private String adicionadoPor, modificadorPor;
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
            this.adicionadoPor = "";
            this.fechaAdicion = DateTime.Now;
            this.modificadorPor = "";
            this.fechaModificacion = DateTime.Now;
        }

        public clsPropietario(int iden, String pnom, String snom, String pape, String sape,
                              String nuid, String corr, String tele, String padicpor, DateTime pfecadic)
        {
            this.identificador = iden;
            this.primerNombre = pnom;
            this.segundoNombre = snom;
            this.primerApellido = pape;
            this.segundoApellido = sape;
            this.numeroIdentificacion = nuid;
            this.correoElectronico = corr;
            this.telefonoCelular = tele;
            this.adicionadoPor = padicpor;
            this.fechaAdicion = pfecadic;
        }
        public clsPropietario(int iden, String pnom, String pape, String sape,
                             String corr, String tele, String pmodpor, DateTime pfecmod)
        {
            this.identificador = iden;
            this.primerNombre = pnom; 
            this.primerApellido = pape;
            this.segundoApellido = sape; 
            this.correoElectronico = corr;
            this.telefonoCelular = tele;
            this.modificadorPor = pmodpor;
            this.fechaModificacion = pfecmod;
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
        public String AdicionadoPor
        {
            set { adicionadoPor = value; }
            get { return adicionadoPor; }
        }
        public DateTime FechaAdicion
        {
            set { fechaAdicion = value; }
            get { return fechaAdicion; }
        }
        public String ModificadoPor
        {
            set { modificadorPor = value; }
            get { return modificadorPor; }
        }
        public DateTime FechaModificacion
        {
            set { fechaModificacion = value; }
            get { return fechaModificacion; }
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
