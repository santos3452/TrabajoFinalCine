using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineBack.AccesoDatos;

namespace CineBack.AccesoDatos

{
    internal class HelperDao
    {
        private static HelperDao instancia; // Instancia única de la clase HelperDao
        private SqlConnection conexion; // Objeto de conexión a la base de datos

        // Constructor privado de la clase HelperDao
        private HelperDao()
        {
            conexion = new SqlConnection(@"Data Source=DESKTOP-U6HBTT5;Initial Catalog=CineDB;Integrated Security=True"); // ACA PONGAN SU CADENA DE CONEXION
        }

        // Método estático que devuelve la instancia única de HelperDao
        public static HelperDao ObtenerInstancia()
        {
            if (instancia == null) // Verifica si la instancia no ha sido creada
            {
                instancia = new HelperDao(); // Crea una nueva instancia si no existe
            }
            return instancia; // Devuelve la instancia existente o recién creada
        }


        public int EjecutarSQL(string strSql, List<Parametro> values)
        {
            int afectadas = 0;
            SqlTransaction t = null;

            try
            {
                
                conexion.Open();
                SqlCommand cmd = new SqlCommand(strSql, conexion, t);
                t = conexion.BeginTransaction();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = strSql;
                cmd.Transaction = t;

                if (values != null)
                {
                    foreach (Parametro param in values)
                    {
                        cmd.Parameters.AddWithValue(param.Clave, param.Valor);
                    }
                }

                afectadas = cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (SqlException)
            {
                if (t != null) { t.Rollback(); }
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();

            }

            return afectadas;
        }






        // Método para ejecutar un procedimiento almacenado que devuelve un valor escalar (un solo valor)
        public int ConsultarEscalar(string nombreSP, string nombreParamOut)
        {
            conexion.Open(); // Abre la conexión a la base de datos
            SqlCommand comando = new SqlCommand(); // Crea un objeto para ejecutar comandos SQL
            comando.Connection = conexion; // Establece la conexión para el comando
            comando.CommandType = CommandType.StoredProcedure; // Indica que se utilizará un procedimiento almacenado
            comando.CommandText = nombreSP; // Establece el nombre del procedimiento almacenado a ejecutar

            SqlParameter parametro = new SqlParameter(); // Crea un parámetro
            parametro.ParameterName = nombreParamOut; // Establece el nombre del parámetro de salida
            parametro.SqlDbType = SqlDbType.Int; // Indica el tipo de dato del parámetro (en este caso, entero)
            parametro.Direction = ParameterDirection.Output; // Indica que es un parámetro de salida

            comando.Parameters.Add(parametro); // Agrega el parámetro al comando
            comando.ExecuteNonQuery(); // Ejecuta el procedimiento almacenado

            conexion.Close(); // Cierra la conexión a la base de datos

            return (int)parametro.Value; // Devuelve el valor del parámetro de salida convertido a entero
        }

        // Método para ejecutar un procedimiento almacenado que devuelve un conjunto de resultados (DataTable) sin parámetros
        public DataTable Consultar(string nombreSP)
        {
            conexion.Open(); // Abre la conexión a la base de datos
            SqlCommand comando = new SqlCommand(); // Crea un objeto para ejecutar comandos SQL
            comando.Connection = conexion; // Establece la conexión para el comando
            comando.CommandType = CommandType.StoredProcedure; // Indica que se utilizará un procedimiento almacenado
            comando.CommandText = nombreSP; // Establece el nombre del procedimiento almacenado a ejecutar

            DataTable tabla = new DataTable(); // Crea un DataTable para almacenar los resultados
            tabla.Load(comando.ExecuteReader()); // Carga el resultado del comando en el DataTable

            conexion.Close(); // Cierra la conexión a la base de datos

            return tabla; // Devuelve el DataTable con los resultados obtenidos
        }

        // Método para ejecutar un procedimiento almacenado que toma una lista de parámetros y devuelve un conjunto de resultados (DataTable)
        //public DataTable Consultar(string nombreSP, List<Parametro> lstParametros)
        //{
        //    conexion.Open(); // Abre la conexión a la base de datos
        //    SqlCommand comando = new SqlCommand(); // Crea un objeto para ejecutar comandos SQL
        //    comando.Connection = conexion; // Establece la conexión para el comando
        //    comando.CommandType = CommandType.StoredProcedure; // Indica que se utilizará un procedimiento almacenado
        //    comando.CommandText = nombreSP; // Establece el nombre del procedimiento almacenado a ejecutar
        //    comando.Parameters.Clear(); // Limpia los parámetros del comando

        //    foreach (Parametro p in lstParametros) // Recorre la lista de parámetros proporcionados
        //    {
        //        comando.Parameters.AddWithValue(p.Nombre, p.Valor); // Agrega los parámetros al comando
        //    }

        //    DataTable tabla = new DataTable(); // Crea un DataTable para almacenar los resultados
        //    tabla.Load(comando.ExecuteReader()); // Carga el resultado del comando en el DataTable

        //    conexion.Close(); // Cierra la conexión a la base de datos

        //    return tabla; // Devuelve el DataTable con los resultados obtenidos
        //}

        // Método para obtener la instancia de la conexión a la base de datos
        public SqlConnection ObtenerConexion()
        {
            return conexion; // Devuelve el objeto de conexión a la base de datos
        }

    }
}
