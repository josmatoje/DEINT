using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using U11_ejerciciosUWP_ej2.ViewModels.Utilidades;

namespace U11_ejerciciosUWP_ej2.ViewModels
{
    public class MainPageVM : clsVMBase
    {
        private DelegateCommand buscador;
        private ObservableCollection<clsPersona> listaPersonaCompleto;
        private ObservableCollection<clsPersona> listaPersonaOfrecido;
        private string textBoxBuscar;
        public MainPageVM()
        {
            ListaPersonaCompleto = new ObservableCollection<clsPersona>(listadoPersonas.buscapersonas());

        }

        public ObservableCollection<clsPersona> ListaPersonaCompleto { get => listaPersonaCompleto; set => listaPersonaCompleto = value; }

        public void Buscar()
        {

        }


        public ICommand Buscar
        {
            get
            {
                
                return buscador;
            }
        }

        private void PerformBuscar()
        {
        }
    }
}
