using Capa_DAL.Listados;
using Capa_DAL.Manejadores;
using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_BL.Manejadores
{
    public class Manejadores_Contabilidad_BL
    {
        #region metodos publicas
        /// <summary>
        /// Cabecera: public static int Insertar_Modificar_Contabilidad_BL(clsContabilidad contabilidad)
        /// Descripcion: llama al metodo Insertar_Modificar_Contabilidad_DAL de la capa DAL
        /// Precondiciones: ninguna
        /// Postcondiciones: ninguna
        /// </summary>
        /// <param name="contabilidad"></param>
        /// <returns></returns>
        public static int Insertar_Modificar_Contabilidad_BL(clsContabilidad contabilidad)
        {
            return Manejadores_Contabilidad_DAL.Insertar_Modificar_Contabilidad_DAL(contabilidad);
        }
        #endregion

    }
}
