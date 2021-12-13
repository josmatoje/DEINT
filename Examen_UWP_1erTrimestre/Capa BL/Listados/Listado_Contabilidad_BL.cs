using Capa_DAL.Listados;
using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_BL.Listados
{
    public class Listado_Contabilidad_BL
    {
        #region metodos publicas
        /// <summary>
        /// Cabecera:public static bool ExisteContabilidadActual_DAL()
        /// Descripcion: Devuelve true en caso de que existan datos de contabilidad del dia actual o false en caso contrario
        /// Precondiciones: ninguna
        /// Postcondiciones: ninguna
        /// </summary>
        /// <returns> Un booleano indicando el resultado</returns>
        public static bool ExisteContabilidadActual_BL()
        {
            return Listado_Contabilidad_DAL.ExisteContabilidadActual_DAL();
        }
        #endregion
    }
}
