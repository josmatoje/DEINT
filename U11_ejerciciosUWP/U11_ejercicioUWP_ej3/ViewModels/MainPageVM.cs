using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using U11_ejerciciosUWP_ej3.ViewModels.Utilidades;

namespace U11_ejerciciosUWP_ej3.ViewModels
{
    public class MainPageVM : clsVMBase
    {
        #region atributos
        private DelegateCommand buscador;
        private DelegateCommand eliminador;
        private ObservableCollection<clsPersona> listaPersonaCompleto;
        private ObservableCollection<clsPersona> listaPersonaOfrecido;
        private string textBoxBuscar;
        private clsPersona personaSeleccionada;
        #endregion
        #region constructor
        public MainPageVM()
        {
            buscador = new DelegateCommand(Buscar, SePuedeBuscar);
            eliminador = new DelegateCommand(Eliminar, SePuedeEliminarar);
            ListaPersonaCompleto = new ObservableCollection<clsPersona>(PersonasDAL.listadoPersonas());
            ListaPersonaOfrecido = ListaPersonaCompleto;
        }
        #endregion
        #region propiedades publicas
        public DelegateCommand Buscador {
            get => buscador; // = new DelegateCommand(Buscar, SePuedeBuscar); // ---> Esta opcion seria igual que la de abajo?
            //get { return buscador = new DelegateCommand(Buscar, SePuedeBuscar); }
        }
        public DelegateCommand Eliminador { 
            get => eliminador;
        }
        public ObservableCollection<clsPersona> ListaPersonaCompleto { get => listaPersonaCompleto; set => listaPersonaCompleto = value; }
        public ObservableCollection<clsPersona> ListaPersonaOfrecido { get => listaPersonaOfrecido; set => listaPersonaOfrecido = value; }
        public string TextBoxBuscar {
            get => textBoxBuscar;
            set
            {
                textBoxBuscar = value;
                if (String.IsNullOrEmpty(value))
                {
                    ListaPersonaOfrecido = ListaPersonaCompleto;
                    NotifyPropertyChanged("ListaPersonaOfrecido");
                }
                buscador.RaiseCanExecuteChanged();
                //NotifyPropertyChanged("TextBoxBuscar"); twoWays hace q no haga falta esto
            }

        }
        public clsPersona PersonaSeleccionada {
            get => personaSeleccionada;
            set
            {
                personaSeleccionada = value;
                eliminador.RaiseCanExecuteChanged();
            }
        }
        #endregion
        #region propiedades privadas
        private void Buscar()
        {
            ListaPersonaOfrecido = new ObservableCollection<clsPersona>(ListaPersonaCompleto.Where(persona => persona.ToString().Contains(TextBoxBuscar)));
            NotifyPropertyChanged("ListaPersonaOfrecido");
        }

        private bool SePuedeBuscar()
        {   //Texto distinto de vacio y null
            return !String.IsNullOrEmpty(TextBoxBuscar);
        }
        private void Eliminar()
        {
            listaPersonaCompleto.Remove(PersonaSeleccionada);
            if (ListaPersonaOfrecido.Contains(PersonaSeleccionada))
                listaPersonaOfrecido.Remove(PersonaSeleccionada);
        }

        private bool SePuedeEliminarar()
        {   //Texto distinto de vacio y null
            return !(PersonaSeleccionada is null);
        }
        #endregion
    }
}
