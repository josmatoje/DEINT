using Capa_DAL.Listados;
using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_BL.Listados
{
    public class Listados_Plantas_BL
    {
        #region metodos publicas
        /// <summary>
        /// Cabecera: public static List<clsPlanta> Listado_Categoria_Plantas_BL(int idCategoria)
        /// Descripcion: Devuelve el conjunto de plantas pertenecientes a la categoria dada que se encuentran en la base de datos a la que se conecta
        /// Precondiciones: ninguna
        /// Postcondiciones: todos los datos de la lista existen en la base de datos
        /// </summary>
        /// <param name="idCategoria"> id de la categoria de la que se queiren saber las plantas</param>
        /// <returns> El listado de todas las categorias que existen en la base de datos</returns>
        public static List<clsPlanta> Listado_Completo_Plantas_BL()
        {
            return Listados_Plantas_DAL.Listado_Completo_Plantas_DAL();
        }
        #endregion
    }
}
