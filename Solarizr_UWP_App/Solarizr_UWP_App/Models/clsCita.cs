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
        private String apellidoCliente;
        private String direccion;
        private String imgLocation;
        private String telefono;
        private String email;
        private DateTime fechaDateTime;
        private String observaciones;
        #endregion
        #region constructores
        public clsCita()
        {
            IdCita = (new Random()).Next(100000).ToString() ;
            NombreCliente = "Fernando";
            ApellidoCliente = "Galliana";
            Direccion = "IES Nervion";
            ImageLocation = "ms-appx:///Assets/Images/mapa.jpeg";
            Telefono = "666666666";
            Email = "fernando.galiana@iesnervion.es";
            FechaDateTime = DateTime.Now.AddDays(1);
            Observaciones = "Esto es una observación predeterminada";
        }
        #endregion
        #region propiedades publicas
        public string IdCita { get => idCita; set => idCita = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string ImageLocation { get => imgLocation; set => imgLocation = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public DateTime FechaDateTime { get => fechaDateTime; set => fechaDateTime = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        #endregion
        #region metodos publicos
        public void atrasaCita(int dias) { FechaDateTime = FechaDateTime.AddDays(dias); }
        public string Fecha() { return $"{FechaDateTime.Day}/{FechaDateTime.Month}/{FechaDateTime.Year}"; }
        public string Hora() {
            var minutos = FechaDateTime.Minute > 9 ? $"{FechaDateTime.Minute}" : $"0{FechaDateTime.Minute}";
            return $"{FechaDateTime.Hour}:{minutos}"; 
        }
        #endregion
    }
}
