using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace DEINT_11_Ejercicio1_UWP_UI.ViewModels
{
    public class clsMainPage_VM //: INotifyPropertyChanged
    {
        private ObservableCollection<clsPersona> listadoPersonas;
        public clsMainPage_VM()
        {
            listadoPersonas = clsListados.getPersonasDefecto();
        }

        public ObservableCollection<clsPersona> ListadoPersonas {
            get
            { return listadoPersonas; }
            set
            {
                listadoPersonas = value;
                
            }
        }
        public clsPersona OPersonaSeleccionada { get; set; }

        //public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void EliminarPersonaClick(object sender, RoutedEventArgs e)
        {
            ListadoPersonas.Remove(OPersonaSeleccionada);
            
        }

        //private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}
    }
}
