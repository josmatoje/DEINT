using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using U10_Ej1_UWPBinding.Models.Entyties;

namespace U10_Ej1_UWPBinding.Models.DAL
{
    public class listadoPersona
    {
        /// <summary>
        /// prototipo: public List(clsPersona) getListadoPersona()
        /// descripción:
        /// precondiciones:
        /// </summary>
        /// <param> ninguno </param>
        /// <returns> List(clsPersona) </returns>
        /// postcondiciones:
        public static List<clsPersona> getListadoPersona()
        {
            List<clsPersona> listado = new List<clsPersona>();

            listado.Add(new clsPersona("Pedro", "Pastor de cabras"));
            listado.Add(new clsPersona("Pedro", "Pastor de cabras"));
            listado.Add(new clsPersona("Pedro", "Pastor de cabras"));
            listado.Add(new clsPersona("Pedro", "Pastor de cabras"));
            listado.Add(new clsPersona("Pedro", "Pastor de cabras"));
            listado.Add(new clsPersona("Pedro", "Pastor de cabras"));
            listado.Add(new clsPersona("Pedro", "Pastor de cabras"));
            listado.Add(new clsPersona("Pedro", "Pastor de cabras"));
            listado.Add(new clsPersona("Pedro", "Pastor de cabras"));
            listado.Add(new clsPersona("Pedro", "Pastor de cabras"));
            listado.Add(new clsPersona("Pedro", "Pastor de cabras"));
            listado.Add(new clsPersona("Pedro", "Pastor de cabras"));
            listado.Add(new clsPersona("Pedro", "Pastor de cabras"));

            return listado;
        }
    }
}
