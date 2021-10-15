using System;

namespace Entidades
{
    public class Persona
    {
        #region atributos privados
        private String nombre;
        #endregion
        #region constructores
        public Persona()
        {
            this.nombre = "";
        }
        public Persona(String nombre)
        {
            this.nombre = nombre;
        }
        #endregion
        #region propiedades publicas
        public String Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        #endregion

    }
}
