using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solarizr_UWP_App.Models
{
    public class clsCita
    {
        #region atributos privados
        private String idCita;
        private String nombreCliente;
        private String direccion;
        private String imgLocation;
        private String telefono;
        private String email;
        private DateTime fecha;
        private String nota;
        #endregion
        #region constructores
        public clsCita()
        {
            IdCitas = (new Random()).Next(100000).ToString() ;
            NombreCliente = "Fernando Galliana";
            Direccion = "IES Nervion";
            ImageLocation = "./Assets/mapa.jepg";
            Telefono = "666666666";
            Email = "fernando.galiana@iesnervion.es";
            Fecha = DateTime.Now.AddDays(1);
            Nota = "";
        }
        #endregion
        #region propiedades publicas
        public string IdCitas { get => idCita; set => idCita = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string ImageLocation { get => imgLocation; set => imgLocation = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Nota { get => nota; set => nota = value; }
        #endregion
        #region metodos publicos
        public void atrasaCita(int dias) { Fecha = Fecha.AddDays(dias); }
        #endregion
    }
}
