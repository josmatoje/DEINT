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
            ListaPersonaCompleto = new ObservableCollection<clsPersona>(PersonasDAL.listadoPersonas());
            ListaPersonaOfrecido = ListaPersonaCompleto;
        }

        public DelegateCommand Buscador {
            get => buscador = new DelegateCommand(Buscar,SePuedeBuscar); // ---> Esta opcion seria igual que la de abajo?
            //get { return buscador = new DelegateCommand(Buscar, SePuedeBuscar); }
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

        private void Buscar()
        {
            ListaPersonaOfrecido = new ObservableCollection<clsPersona>(ListaPersonaCompleto.Where(persona => persona.ToString().Contains(TextBoxBuscar)));
            NotifyPropertyChanged("ListaPersonaOfrecido");
        }

        private bool SePuedeBuscar()
        {   //Texto distinto de vacio y null
            return !String.IsNullOrEmpty(TextBoxBuscar);
        }

    }
}
