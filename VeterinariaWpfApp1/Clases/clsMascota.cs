using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaWpfApp.Clases
{
    public class clsMascota
    {
        #region Atributos
        private int identificador;
        private String nombre, alergias;
        private DateTime fechaNacimiento;
        private char sexo;
        private decimal peso;
        private int idPropietario;
        private DateTime fechaAdicion, fechaModificacion;
        private String adicionadoPor, modificadorPor;
        #endregion

        #region Constructores
        public clsMascota()
        {
            this.identificador = 0;
            this.nombre = "";
            this.fechaNacimiento = Convert.ToDateTime("01/01/1990");
            this.sexo = '*';
            this.peso = 0;
            this.alergias = "";
            this.idPropietario = 0;
            this.adicionadoPor = "";
            this.fechaAdicion = DateTime.Now;
            this.modificadorPor = "";
            this.fechaModificacion = DateTime.Now;
        }

        public clsMascota(int iden, String nomb, DateTime fnac, char sex, Decimal pes, String aler,
            int ipro, String padicpor, DateTime pfecadic)
        {
            this.identificador = iden;
            this.nombre = nomb;
            this.fechaNacimiento = fnac;
            this.sexo = sex;
            this.peso = pes;
            this.alergias = aler;
            this.idPropietario = ipro;
            this.adicionadoPor = padicpor;
            this.fechaAdicion = pfecadic;
        }
        public clsMascota(int iden, String nomb, Decimal pes, String aler, String pmodpor, DateTime pfecmod)
        {
            this.identificador = iden;
            this.nombre = nomb;
            this.peso = pes;
            this.alergias = aler;
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
        public String Nombre
        {
            set { nombre = value.ToUpper(); }
            get { return nombre; }
        }

        public DateTime FechaNacimiento
        {
            set { fechaNacimiento = value; }
            get { return fechaNacimiento; }
        }
        public char Sexo
        {
            set { sexo = value; }
            get { return sexo; }
        }
        public decimal Peso
        {
            set { peso = value; }
            get { return peso; }
        }
        public String Alergias
        {
            set { alergias = value.ToUpper(); }
            get { return alergias; }
        }
        public int IdentificadorPropietario
        {
            set { idPropietario = value; }
            get { return idPropietario; }
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
            dato = " Nombre: " + this.nombre + "\n" +
                   " Fecha de nacimiento: " + this.fechaNacimiento + "\n" +
                   " Sexo: " + this.sexo + "\n" +
                   " Peso: " + this.peso + "\n" +
                   " Alergias: " + this.alergias + "\n" +
                   " Id Propietario: " + this.idPropietario;
            return dato;
        }
        #endregion
    }
}
