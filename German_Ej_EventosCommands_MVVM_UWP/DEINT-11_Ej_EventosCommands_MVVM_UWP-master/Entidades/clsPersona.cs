using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsPersona
    {

        #region atributos privados
        private string nombre;
        private string apellidos;
        #endregion
        #region constructores
        //Constructor por defecto
        public clsPersona()
        {
        }
        //Constructores por parametros
        public clsPersona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellidos = apellido;
        }
        public clsPersona(string nombre, string apellido, DateTime fechaNacimiento, String direccion, int telefono)
        {
            Nombre = nombre;
            Apellidos = apellido;
            FechaNacimiento = fechaNacimiento;
            Direccion = direccion;
            Telefono = telefono;
        }
        #endregion
        //GET +  SET
        #region propiedades publicas
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            { nombre = value; }
        }
        public string Apellidos
        {
            get
            { return apellidos; }
            set
            { apellidos = value; }
        }

        public DateTime FechaNacimiento { get; set; }
        public String Direccion { get; set; }
        public int Telefono { get; set; }
        #endregion
    }
}
