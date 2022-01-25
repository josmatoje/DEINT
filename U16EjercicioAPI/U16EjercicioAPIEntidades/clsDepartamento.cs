using System;
using System.Collections.Generic;
using System.Text;

namespace U16EjercicioAPIEntidades
{
    public class clsDepartamento
    {
        #region propiedades publicas
        public int ID { get; set; }
        [Required, MaxLength(24)]
        public string Nombre { get; set; }
        #endregion propiedades
        #region constructores
        public clsDepartamento() { }
        public clsDepartamento(int id, string nombre)
        {
            ID = id;
            Nombre = nombre;
        }
        #endregion
    }
}
