using System;

namespace Entidades
{
    public class Persona
    {
        #region atributos privados
        private String nombre;
        private String apellidos;
        #endregion
        #region constructores
        public Persona()
        {
            this.nombre = "";
        }
        public Persona(String nombre)
        {
            this.nombre = nombre;
            this.apellidos = "apellido";
        }
        #endregion
        #region propiedades publicas
        public String Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public String Apellidos
        {
            get => apellidos;
            set => apellidos = value;
        }
        #endregion

    }
}
