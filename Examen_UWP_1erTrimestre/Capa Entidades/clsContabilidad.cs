using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Entidades
{
    public class clsContabilidad
    {
        #region atributos
        private DateTime fechaActual;
        private float recaudacionDada;
        private float recaudacionReal;
        #endregion
        #region constructores
        public clsContabilidad()
        {
            FechaActual = DateTime.MinValue;
            RecaudacionDada = 0;
            RecaudacionReal = 0;
        }
        public clsContabilidad(DateTime fechaActual, float recaudacionDada, float recaudacionReal)
        {
            FechaActual = fechaActual;
            RecaudacionDada = recaudacionDada;
            RecaudacionReal = recaudacionReal;
        }
        #endregion
        #region propiedades publicas
        public DateTime FechaActual { get => fechaActual; set => fechaActual = value; }
        public float RecaudacionDada { get => recaudacionDada; set => recaudacionDada = value; }
        public float RecaudacionReal { get => recaudacionReal; set => recaudacionReal = value; }
        #endregion
    }
}
