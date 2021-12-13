using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Capa_DAL.Listados
{
    public class Listado_Contabilidad_DAL
    {
        #region propiedad privada
        private static clsMyConexion conexionDAL = new clsMyConexion();
        #endregion
        #region metodos publicas
        /// <summary>
        /// Cabecera:public static bool ExisteContabilidadActual_DAL()
        /// Descripcion: Devuelve true en caso de que existan datos de contabilidad del dia actual o false en caso contrario
        /// Precondiciones: ninguna
        /// Postcondiciones: ninguna
        /// </summary>
        /// <returns> Un booleano indicando el resultado</returns>
        public static bool ExisteContabilidadActual_DAL()
        {
            SqlCommand instruccion = new SqlCommand();
            SqlDataReader lector;
            bool existeContabilidad=false;

            try
            {
                conexionDAL.abrirConexion();
                instruccion.CommandText = @"DECLARE @date AS DATE = CURRENT_TIMESTAMP 
                                            SELECT* FROM Contabilidad WHERE fecha = @date"; //NO CONSIGUE SACAR CURRRENT_TIMESTAMP como tipo date desde c#
                instruccion.Connection = conexionDAL.SqlConexion;
                lector = instruccion.ExecuteReader();
                existeContabilidad = lector.HasRows;
                lector.Close();
                conexionDAL.cerrarConexion();
            }
            catch (SqlException e)
            {
                throw;
            }

            return existeContabilidad;
        }
        #endregion
    }
}
