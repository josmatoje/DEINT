using Solarizr_UWP_App.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solarizr_UWP_App.ViewModels
{
    public class CitaVM
    {
        #region atributos privados
        private ObservableCollection<clsCita> listadoCitas ;
        #endregion
        #region constructores
        public CitaVM()
        {
            ListadoCitas = new ObservableCollection<clsCita>();
            for (int i = 0; i < 20; i++)
            {
                clsCita cita = new clsCita();
                cita.anhadeDias(i);
                ListadoCitas.Add(cita);

            }
        }
        public CitaVM(int numCitas)
        {
            this.listadoCitas = new ObservableCollection<clsCita>();
            for (int i = 0; i < numCitas; i++)
            {
                clsCita cita = new clsCita();
                cita.anhadeDias(i);
                this.listadoCitas.Add(cita);
            }
        }
        #endregion
        #region propiedades publicas

        public ObservableCollection<clsCita> ListadoCitas { get { return listadoCitas; } set => listadoCitas = value; }
        #endregion
    }
}
