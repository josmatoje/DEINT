using Capa_BL.Listados;
using Capa_Entidades;
using Examen_UWP_1erTrimestre.Model;
using Examen_UWP_1erTrimestre.ViewModels.Utilidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_UWP_1erTrimestre.ViewModels
{
    public class MainPageVM : clsVMBase
    {
        #region atributos
        private ObservableCollection<clsPlantaCantidad> listadoPlantas;
        private clsContabilidad contabilidadActual;
        #endregion
        #region constructores
        public MainPageVM()
        {
            try
            {
                listadoPlantas = new ObservableCollection<clsPlantaCantidad>();
                Listados_Plantas_BL.Listado_Completo_Plantas_BL().ForEach(x => listadoPlantas.Add(new clsPlantaCantidad(x)));

            }
            catch
            {
                throw;
            }
            ContabilidadActual = new clsContabilidad();
            ContabilidadActual.FechaActual = DateTime.Now;
            //ContabilidadActual.FechaActual = DateTime.Parse("08/09/1995");
        }
        #endregion
        #region propiedades publicas
        public ObservableCollection<clsPlantaCantidad> ListadoPlantas { get => listadoPlantas;}
        public clsContabilidad ContabilidadActual { 
            get => contabilidadActual;
            set { 
                contabilidadActual = value;
                NotifyPropertyChanged(nameof(ContabilidadActual));
            } 
        }
        #endregion
        #region metodos
        /// <summary>
        /// Descripcion: metodo que calcula la recaudacion dada y la muestra en la vista
        /// </summary>
        public void calcular()
        {
            float total=0;

            //Recorremos Listado de plantas y hacemos las operaciones pertinentes

            ContabilidadActual.RecaudacionDada = total;
        }
        /// <summary>
        /// Descripcion: Coge los datos de los campos de la vista recaudacionDada y recaudacionTotal y los inserta en la bBDD
        /// </summary>
        public void guardar()
        {
            //Realiza la insercion con clsContabilidad
        }
        #endregion
    }
}
