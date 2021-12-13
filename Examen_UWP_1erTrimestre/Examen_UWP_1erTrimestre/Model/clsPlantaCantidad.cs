using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_UWP_1erTrimestre.Model
{
    public class clsPlantaCantidad : clsPlanta
    {
        #region atributos
        private double cantidad;
        #endregion
        #region constructor
        public clsPlantaCantidad() { }
        public clsPlantaCantidad(clsPlanta planta, int cantidad) : base(planta)
        {
            Cantidad = cantidad;
        }
        public clsPlantaCantidad(clsPlanta planta) : base(planta) 
        {
            Cantidad = 0.0;
        }
        #endregion
        #region propiedades publicas
        public double Cantidad { get => cantidad; set => cantidad = value; }
        #endregion
    }
}
