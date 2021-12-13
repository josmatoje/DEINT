using Capa_DAL.Listados;
using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Capa_DAL.Manejadores
{
    public class Manejadores_Contabilidad_DAL
    {
        #region propiedad privada
        private static clsMyConexion conexionDAL = new clsMyConexion();
        #endregion
        #region metodos publicas
        /// <summary>
        /// Cabecera: public static int Insertar_Modificar_Contabilidad_DAL(clsContabilidad contabilidad)
        /// Descripcion: inserta los datos de la contabilidad  del dia actual o actualiza en caso de existir datos previos
        /// Precondiciones: ninguna
        /// Postcondiciones: ninguna
        /// </summary>
        /// <param name="contabilidad"></param>
        /// <returns></returns>
        public static int Insertar_Modificar_Contabilidad_DAL(clsContabilidad contabilidad)
        {
            int numeroFilasAfectadas=0;
            conexionDAL.abrirConexion();
            SqlCommand instruccion;
            if (Listado_Contabilidad_DAL.ExisteContabilidadActual_DAL())
            {
                instruccion = new SqlCommand(@"INSERT INTO contabilidad (fecha, recaudacionDada, recaudacionReal) 
                                                            VALUES(CURRENT_TIMESTAMP, @recaudacionDada, @recaudacionReal)",
                                                            conexionDAL.SqlConexion);
            }
            else
            {
                instruccion = new SqlCommand(@"DECLARE @date AS DATE = CURRENT_TIMESTAMP 
                                                UPDATE contabilidad SET recaudacionDada=@recaudacionDada, 
                                                                        recaudacionReal=@recaudacionReal) 
                                                            WHERE (fecha=@date)",
                                            conexionDAL.SqlConexion);
            }
            instruccion.Parameters.AddWithValue("@recaudacionDada", (contabilidad.RecaudacionDada));
            instruccion.Parameters.AddWithValue("@recaudacionReal", contabilidad.RecaudacionReal);
            
            numeroFilasAfectadas = instruccion.ExecuteNonQuery();
            conexionDAL.cerrarConexion();
            return numeroFilasAfectadas;
        }
        #endregion

    }
}
