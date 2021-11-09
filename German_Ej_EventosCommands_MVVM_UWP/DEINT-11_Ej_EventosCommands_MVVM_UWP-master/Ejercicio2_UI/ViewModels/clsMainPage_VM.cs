using DAL;
using Ejercicio2_UI.ViewModels.Utilidades;
using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;

namespace Ejercicio2_UI.ViewModels
{
    public class clsMainPage_VM : DelegateCommand
    {
        #region atributos
        #endregion
        public ObservableCollection<clsPersona> ListadoPersonas { get; set; }
        public clsPersona OPersonaSeleccionada { get; set; }
        //TODO CUIDAOOOO ***************************************
        private String textoTxtBox;
        public String TextoTxtBox {
            get { return textoTxtBox; }
            set
            {
                textoTxtBox = value;
                
            }
        }
        //TODO CUIDAOOOO ***************************************

        private DelegateCommand filtrarListaCommand;

        public clsMainPage_VM()
        {
            ListadoPersonas = clsListados.getPersonasDefecto();
        }



        #region propiedades publicas
        public DelegateCommand FiltrarListaCommand
        {
            get
            {
                return filtrarListaCommand = new DelegateCommand(FiltrarListaCommand_Execute, FiltrarListaCommand_CanExecute);
            }
        }

        private void FiltrarListaCommand_Execute()
        {
            String filtro = TextoTxtBox;
            ObservableCollection<clsPersona> listaAuxiliarPersonas = ListadoPersonas;
            for (int i = 0; i<listaAuxiliarPersonas.Count();i++)
            {
                if (!listaAuxiliarPersonas[i].Nombre.Contains(filtro))
                {
                    ListadoPersonas.Remove(ListadoPersonas[i]);
                }
            }
        }

        private bool FiltrarListaCommand_CanExecute()
        {
            return String.IsNullOrEmpty(TextoTxtBox);
        }

        


        #endregion

        #region metodos ICommand

        #endregion





    }
}
