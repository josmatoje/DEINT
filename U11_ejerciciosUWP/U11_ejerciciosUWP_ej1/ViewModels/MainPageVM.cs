using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U11_ejerciciosUWP_ej1.ViewModels
{
    public class MainPageVM
    {
        private ObservableCollection<clsPersona> listaPersona;
        private clsPersona personaSeleccionada;
        public MainPageVM()
        {
            ListaPersona =new ObservableCollection<clsPersona>(listadoPersonas.buscapersonas());
            PersonaSeleccionada = new clsPersona();
        }

        public clsPersona PersonaSeleccionada { get => personaSeleccionada; set => personaSeleccionada = value; }
        public ObservableCollection<clsPersona> ListaPersona { get => listaPersona; set => listaPersona = value; }

        public void eliminaPersona()
        {
            ListaPersona.Remove(PersonaSeleccionada);

        }
    }
}
