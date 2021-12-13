using System;

namespace Capa_Entidades
{
    public class clsPlanta
    {
        #region atributos
        private int idPlanta;
        private string nombrePlanta;
        private string descripcion;
        private int idCategoria;
        private double precio;
        #endregion
        #region propiedades publicas
        public int IdPlanta { get => idPlanta; set => idPlanta = value; }
        public string NombrePlanta { get => nombrePlanta; set => nombrePlanta = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public double Precio { get => precio; set => precio = value; }
        #endregion
        #region constructores
        public clsPlanta() { }
        public clsPlanta(int idPlanta, string nombrePlanta, string descripcion, int idCategoria, double precio)
        {
            IdPlanta = idPlanta;
            NombrePlanta = nombrePlanta;
            Descripcion = descripcion;
            IdCategoria = idCategoria;
            Precio = precio;
        }
        public clsPlanta(clsPlanta planta)
        {
            IdPlanta = planta.idPlanta;
            NombrePlanta = planta.nombrePlanta;
            Descripcion = planta.descripcion;
            IdCategoria = planta.idCategoria;
            Precio = planta.precio;
        }
        #endregion
    }
}
