using U10_Ej1_UWPBinding.Models.Entyties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using U10_Ej1_UWPBinding.Models.DAL;

namespace U10_Ej1_UWPBinding.ViewModels
{
    class Ejercicio4VM
    {
        #region atributos
        private ObservableCollection<clsPersona> oListaUsuarios;
        private clsPersona oPersonaSeleccionadao;

        #endregion

        #region constructores
        public Ejercicio4VM()
        {
            oListaUsuarios = new ObservableCollection<clsPersona>(listadoPersona.getListadoPersona());
        }
        public Ejercicio4VM(ObservableCollection<clsPersona> listaUsuarios, clsPersona usuario)
        {
            this.oListaUsuarios = listaUsuarios;
            this.oPersonaSeleccionadao = usuario;
        }
        #endregion

        #region metodos publicos

        #endregion
    }
}
