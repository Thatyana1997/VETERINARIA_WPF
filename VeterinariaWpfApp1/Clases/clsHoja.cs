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
        #endregion

        #region Constructores
        public clsHoja()
        {
            this.identificador = 0;
            this.sintomas = "";
            this.diagnostico = "";
            this.tratamiento = "";
            this.idMascota = 0;
        }

        public clsHoja(int iden, String sint, String diag, String trat, int imas)
        {
            this.identificador = iden;
            this.sintomas = sint;
            this.diagnostico = diag;
            this.tratamiento = trat;
            this.idMascota = imas;
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
