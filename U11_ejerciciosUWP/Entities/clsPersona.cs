using System;
using System.Collections.Generic;

namespace Entities
{
    public class clsPersona
    {
        #region atributos privados
        private String nombre;
        private String apellido;
        #endregion
        #region constructores
        public clsPersona()
        {
            this.nombre = "Jose Maria";
            this.apellido = "Mata Ojeda";
        }
        public clsPersona(String nombre, String apellido)
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

        public override bool Equals(object obj)
        {
            return obj is clsPersona persona &&
                   nombre == persona.nombre &&
                   apellido == persona.apellido &&
                   Nombre == persona.Nombre &&
                   Apellido == persona.Apellido;
        }
        public override string ToString() => $"{Nombre} {Apellido}";

        #endregion


    }
}
