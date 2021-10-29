using Models.Entyties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace U10_Ej1_UWPBinding.Models.DAL
{
    public class listadoPersona
    {
        //public List<clsPersona>{};
        public List<clsPersona> getListadoPersona()
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
