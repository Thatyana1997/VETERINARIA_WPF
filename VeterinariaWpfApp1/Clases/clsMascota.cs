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
        }

        public clsMascota(int iden, String nomb, DateTime fnac, char sex, Decimal pes, String aler, int ipro)
        {
            this.identificador = iden;
            this.nombre = nomb;
            this.fechaNacimiento = fnac;
            this.sexo = sex;
            this.peso = pes;
            this.alergias = aler;
            this.idPropietario = ipro;
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
        #endregion

        #region Funciones y Procedimientos
        public String imprimirDatos()
        {
            string dato = "";
            dato = " Nombre: " + this.nombre + "\n" +
                   " Fecha de nacimiento: " + this.fechaNacimiento + "\n" +
                   " Sexo: " + this.sexo + "\n" +
                   " Peso: " + this.peso + "\n" +
                   " Alergias: " + this.alergias + "\n"+
                   " Id Propietario: " + this.idPropietario;
            return dato;
        }
        #endregion
    }
}
