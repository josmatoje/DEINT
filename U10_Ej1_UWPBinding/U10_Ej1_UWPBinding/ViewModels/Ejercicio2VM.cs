using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using U10_Ej1_UWPBinding.Models.Entyties;

namespace U10_UWPBinding.ViewModels
{
    public class Ejercicio2VM
    {
        private clsPersona oPersona = new clsPersona("","");

        public bool visible { get; set; } //Propiedad para controlar el ViewModel
        public clsPersona OPersona {
            get { return oPersona;}
            set { oPersona = value;} 
        }


        
    }
}
