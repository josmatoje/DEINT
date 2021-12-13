using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Capa_DAL.Listados
{
    public class Listados_Plantas_DAL
    {
        #region propiedad privada
        private static clsMyConexion conexionDAL = new clsMyConexion();
        #endregion
        #region metodos publicas
        /// <summary>
        /// Cabecera: public static List<clsPlanta> Listado_Categoria_Plantas_DAL(int idCategoria)
        /// Descripcion: Devuelve el conjunto de plantas pertenecientes a la categoria dada que se encuentran en la base de datos a la que se conecta
        /// Precondiciones: ninguna
        /// Postcondiciones: todos los datos de la lista existen en la base de datos
        /// </summary>
        /// <param name="idCategoria"> id de la categoria de la que se queiren saber las plantas</param>
        /// <returns> El listado de todas las categorias que existen en la base de datos</returns>
        public static List<clsPlanta> Listado_Completo_Plantas_DAL()
        {
            List<clsPlanta> departamentos = new List<clsPlanta>();
            SqlCommand instruccion = new SqlCommand();
            SqlDataReader lector;
            clsPlanta oPlanta;

            try
            {
                conexionDAL.abrirConexion();
                instruccion.CommandText = "SELECT idPlanta, nombrePlanta, descripcion, idCategoria, precio FROM Plantas";
                instruccion.Connection = conexionDAL.SqlConexion;
                lector = instruccion.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        oPlanta = generaPlantaLeida(lector);
                        departamentos.Add(oPlanta);
                    }
                }
                lector.Close();
                conexionDAL.cerrarConexion();
            }
            catch (SqlException e)
            {
                throw;
            }

            return departamentos;
        }
        /// <summary>
        /// Cabecera: private static clsPlanta generaPlantaLeida(SqlDataReader lector)
        /// Descripcion: Devuelve una planta leida por un lector
        /// Precondiciones: el SqlDataReader debe haber leido una fila de la consulta realizada
        /// Postcondiciones: la planta existe en la base de datos
        /// </summary>
        /// <param name="lector"> que ha leido una fila de la consulta previamente realizada</param>
        /// <returns>una planta que se encuentra en la base de datos</returns>
        private static clsPlanta generaPlantaLeida(SqlDataReader lector)
        {
            clsPlanta oPlanta = new clsPlanta();
            oPlanta.IdPlanta = (int)lector["IdPlanta"];
            oPlanta.NombrePlanta = (string)lector["nombrePlanta"];
            oPlanta.Descripcion = lector["Descripcion"] != System.DBNull.Value ? (string)lector["descripcion"] : null;
            oPlanta.IdCategoria = (int)lector["IdCategoria"];
            oPlanta.Precio = lector["Precio"] != System.DBNull.Value ? (double)lector["Precio"] : 0;

            return oPlanta;
        }
        #endregion
    }
}
