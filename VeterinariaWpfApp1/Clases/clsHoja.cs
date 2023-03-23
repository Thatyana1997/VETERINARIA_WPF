using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaWpfApp.Clases
{
    public class clsHoja
    {
        #region Atributos
        private int identificador;
        private String sintomas, diagnostico, tratamiento;
        private int idMascota;
        private DateTime fechaAdicion, fechaModificacion;
        private String adicionadoPor, modificadorPor;
        #endregion

        #region Constructores
        public clsHoja()
        {
            this.identificador = 0;
            this.sintomas = "";
            this.diagnostico = "";
            this.tratamiento = "";
            this.idMascota = 0;
            this.adicionadoPor = "";
            this.fechaAdicion = DateTime.Now;
            this.modificadorPor = "";
            this.fechaModificacion = DateTime.Now;
        }

        public clsHoja(int iden, String sint, String diag, String trat, int imas, String padicpor, DateTime pfecadic)
        {
            this.identificador = iden;
            this.sintomas = sint;
            this.diagnostico = diag;
            this.tratamiento = trat;
            this.idMascota = imas;
            this.adicionadoPor = padicpor;
            this.fechaAdicion = pfecadic;
        }
        public clsHoja(bool editar, int iden, String sint, String diag, String trat, int imas, String pmodpor, DateTime pfecmod)
        {
            this.identificador = iden;
            this.sintomas = sint;
            this.diagnostico = diag;
            this.tratamiento = trat;
            this.idMascota = imas;
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
        public String Sintomas
        {
            set { sintomas = value.ToUpper(); }
            get { return sintomas; }
        }
        public String Diagnostico
        {
            set { diagnostico = value.ToUpper(); }
            get { return diagnostico; }
        }
        public String Tratamiento
        {
            set { tratamiento = value.ToUpper(); }
            get { return tratamiento; }
        }
        public int IdentificadorMascota
        {
            set { idMascota = value; }
            get { return idMascota; }
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
            dato = " Sintomas: " + this.sintomas + "\n" +
                   " Diagnostico: " + this.diagnostico + "\n" +
                   " Tratamiento: " + this.tratamiento + "\n" +
                   " Id Mascota: " + this.idMascota;
            return dato;
        }
        #endregion
    }
}
