using System;

namespace Entidades
{
    public class Persona
    {
        #region atributos privados
        private String nombre;
        private String apellido;
        #endregion
        #region constructores
        public Persona()
        {
            this.nombre = "Jose Maria";
            this.apellido = "Mata Ojeda";
        }
        public Persona(String nombre, String apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion
        #region propiedades publicas
        public String Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public String Apellido
        {
            get => apellido;
            set => apellido = value;
        }
        #endregion

    }
}
