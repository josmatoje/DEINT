using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solarizr_UWP_App.Models.ViewModels
{
    class AnhadirImagenVM //En construccion
    {
        #region atributos privados
        private ObservableCollection<string> listadoCitas;
        #endregion
        #region constructores
        public AnhadirImagenVM()
        {
            List<String> lista = new List<string>();
            lista.Add("/Assets/Images/tejado1.jpg");
            lista.Add("/Assets/Images/tejado2.jpg");
            lista.Add("/Assets/Images/tejado3.jpg");
            lista.Add("/Assets/Images/tejado4.jpg");
        }
        #endregion
        #region propiedades publicas
        public ObservableCollection<string> ListadoCitas { get { return listadoCitas; } set => listadoCitas = value; }
        #endregion
    }
}
