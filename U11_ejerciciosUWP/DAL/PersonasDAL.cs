using Entities;
using System;
using System.Collections.Generic;

namespace DAL
{
    public class PersonasDAL
    {

        //public listadoPersonas()
        //{
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <returns>listado </returns>
        public static List<clsPersona> listadoPersonas()
        {
            List<clsPersona> listado = new List<clsPersona>();
            listado.Add(new clsPersona("Hasta luego", "Maricarmen"));
            listado.Add(new clsPersona("Joder", "Que asco"));
            listado.Add(new clsPersona("Vaya", "Sufrimiento"));
            listado.Add(new clsPersona("Me vuelvo", "Loooko"));
            listado.Add(new clsPersona("Demoño", "Demoño"));
            listado.Add(new clsPersona("Joder", "los demoños"));
            listado.Add(new clsPersona("Me comen", "los demoños"));
            return listado;
        }
    }
}
