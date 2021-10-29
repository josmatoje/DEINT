using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace U10_Ej1_UWPBinding.Models.Entyties
{
    public class clsPersona : INotifyPropertyChanged
    {
        #region atributos privados
        private String nombre;
        private String apellido;
        #endregion
        #region constructores
        public clsPersona()
        {
            nombre = "Jose Maria";
            apellido = "Mata Ojeda";
        }
        public clsPersona(String nombre, String apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion
        #region propiedades publicas
        //public String Nombre { get; set; }
        public String Nombre {
            get {
                return nombre;
            }
            set {
                if(value.Contains("n")|| (value.Contains("N")))
                {
                    apellido = "";
                    NotifyPropertyChanged(Apellido);
                }   
                nombre = value;
            }
        }
        //public String Apellido { get; set; }
        public String Apellido {
            get {
                return apellido;
            }
            set {
                if (value.Contains("n") || value.Contains("N"))
                {   nombre = "";
                    NotifyPropertyChanged(Nombre);
                }
                apellido = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
