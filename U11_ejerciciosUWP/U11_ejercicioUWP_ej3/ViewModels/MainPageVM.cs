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
                    listaPersonaOfrecido = listaPersonaCompleto;
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
            //listaPersonaOfrecido = new ObservableCollection<clsPersona>(listaPersonaCompleto.Where(persona => persona.ToString().ToLower().Contains(TextBoxBuscar)));
            listaPersonaOfrecido = new ObservableCollection<clsPersona>(from personas in listaPersonaCompleto
                                                                        where   personas.Nombre.ToLower().Contains(textBoxBuscar) ||
                                                                                personas.Apellido.ToLower().Contains(textBoxBuscar)
                                                                        select personas);
            NotifyPropertyChanged("ListaPersonaOfrecido");
        }

        private bool SePuedeBuscar()
        {   //Texto distinto de vacio y null
            return !String.IsNullOrEmpty(textBoxBuscar);
        }
        private void Eliminar()
        {
            listaPersonaCompleto.Remove(personaSeleccionada);
            //Mejor actualizar de la completa
            if (listaPersonaOfrecido.Contains(personaSeleccionada))
                listaPersonaOfrecido.Remove(personaSeleccionada);
        }

        private bool SePuedeEliminarar()
        {   //Personadeleccionada distinto de vacio y null
            return !(personaSeleccionada is null);
        }
        #endregion
    }
}
