using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U10_Ej1_UWPBinding.ViewModels
{
    public class Ejercicio2VM
    {
        private Persona oPersona = new Persona("","");

        public bool visible { get; set; } //Propiedad para controlar el ViewModel
        public Persona OPersona {
            get { return oPersona;}
            set { oPersona = value;} 
        }


        
    }
}
