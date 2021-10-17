using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DAL_DataAccesLayer_
{
    public class clsListadoPersonasDAL
    {
     /// <summary>
     /// Función que nos devuelve un listado de todas las personas
     /// </summary>
     /// <returns>Listado de personas</returns>
        public static List<Persona> getListadoCompletoPersonas()
        {
            List<Persona> gente = new List<Persona>();
            //....rellenar un listado con varias personas..
            gente.Add(new Persona("Fernando Extra"));
            gente.Add(new Persona("Fernando Demoño"));
            gente.Add(new Persona("Fernando Mejorado"));
            gente.Add(new Persona("Este tambien es Fernando"));
            gente.Add(new Persona("Fernando otra vez"));
            return gente;
        }

    }
}
