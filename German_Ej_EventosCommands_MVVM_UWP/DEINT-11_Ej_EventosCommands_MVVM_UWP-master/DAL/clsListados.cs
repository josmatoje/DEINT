using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsListados
    {
        /// <summary>
        /// Devuelve un ObservableCollection de tipo clsPersona con personas por defecto
        /// </summary>
        /// <returns>List(clsPersona) listaPersonas</returns>
        public static ObservableCollection<clsPersona> getPersonasDefecto()
        {
            ObservableCollection<clsPersona> listadoPersonas = new ObservableCollection<clsPersona>();
            listadoPersonas.Add(new clsPersona("Fernando", "Galiana", new DateTime(1975, 03, 06), "Calle Departamento Informático", 954575965));
            listadoPersonas.Add(new clsPersona("German", "ErBusta", new DateTime(2001, 07, 06), "Plaza Trancho 32", 674058484));
            listadoPersonas.Add(new clsPersona("Paco", "Para", new DateTime(1900, 07, 07), "Calle Simanca 13", 688249514));
            listadoPersonas.Add(new clsPersona("Melo", "Pelu", new DateTime(2004, 05, 04), "Calle Jhonny Memoni", 612548123));
            listadoPersonas.Add(new clsPersona("Guillermo", "2.0", new DateTime(1999, 10, 12), "Plaza España 12", 647588596));
            listadoPersonas.Add(new clsPersona("Carmelo", "Wazosli", new DateTime(1996, 05, 05), "Calle Urbion 12", 674096533));
            return listadoPersonas;
        }
    }
}
