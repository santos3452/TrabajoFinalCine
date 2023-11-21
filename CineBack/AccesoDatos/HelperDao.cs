using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineBack.AccesoDatos;
using CineBack.Entidades;

namespace CineBack.AccesoDatos

{
    internal class HelperDao
    {
        private static HelperDao instancia; // Instancia única de la clase HelperDao
        private SqlConnection conexion; // Objeto de conexión a la base de datos
        private SqlCommand comando = new SqlCommand();

        // Constructor privado de la clase HelperDao
        private HelperDao()
        {
            conexion = new SqlConnection(@"Data Source=BRANDON;Initial Catalog=CineDB24689123;Integrated Security=True"); // ACA PONGAN SU CADENA DE CONEXION
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


        private void Conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
        }


        private void Desconectar()
        {
            conexion.Close();
        }


        public async Task<int> EjecutarSQL(string strSql, List<Parametro> values)
        {

            SqlCommand cmd = new SqlCommand();
            
            int filasAfectadas = 0;

            try
            {
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = strSql;
                cmd.Parameters.Clear();
                foreach (Parametro p in values)
                {
                    cmd.Parameters.AddWithValue(p.Clave, p.Valor);
                }
                filasAfectadas = await cmd.ExecuteNonQueryAsync();
                //cnn.Close();
                return filasAfectadas;
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        public async Task <DataTable> ConsultaFiltros(string spNombre, List<Parametro> values)
        {
            DataTable tabla = new DataTable();
            try
            {
                
                conexion.Open();
                SqlCommand cmd = new SqlCommand(spNombre, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                if (values != null)
                {
                    foreach (Parametro oParametro in values)
                    {
                        cmd.Parameters.AddWithValue(oParametro.Clave, oParametro.Valor);
                    }
                }
                tabla.Load(await cmd.ExecuteReaderAsync());


                return tabla;
            }
            
            catch (Exception ex)
            {

                throw(ex);
            }
            finally
            {
                Desconectar();

            }
           
        }


        public async Task<DataTable> Consultar(string nombreSP)
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }

            

            DataTable tabla = new DataTable();
            try
            {
                
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = nombreSP;
               
                tabla.Load(await comando.ExecuteReaderAsync());
                return tabla;
            }
            catch (Exception e)
            {

                throw e ;
            }

            finally
            {
                conexion.Close();

            }
      
        }
        public async Task<bool> EjecutarMaestroDetalle(string spMaestro, string spDetalle, TicketFactura ticket)
        {
            bool control = true;
            SqlTransaction t = null;

            try
            {
                Conectar();
                t = conexion.BeginTransaction();
                comando.Transaction = t;

                // MAESTRO
                comando.Parameters.Clear();
                comando.CommandText = spMaestro;
                // CARGA PARAMETROS

                comando.Parameters.AddWithValue("@fecha", DateTime.Today);
                comando.Parameters.AddWithValue("@id_cliente", ticket.id_cliente); ;
                comando.Parameters.AddWithValue("@id_forma", ticket.id_forma);
                comando.Parameters.AddWithValue("@totalfinal", ticket.totalfinal);

                SqlParameter pOut = new SqlParameter("@id_factura", SqlDbType.Int);
                pOut.Direction = ParameterDirection.Output;
                comando.Parameters.Add(pOut);

                await comando.ExecuteNonQueryAsync();
                int id = (int)pOut.Value;
                comando.Parameters.Clear();

                // DETALLE


                foreach (DetalleTicketFactura detalle in ticket.Detalle)
                {
                   
                    comando.CommandText = spDetalle;

                    // CARGA PARAMETROS
                    comando.Connection = conexion;
                    comando.Transaction = t;
                    comando.Parameters.AddWithValue("@id_factura", (int)pOut.Value);
                    comando.Parameters.AddWithValue("@id_butaca", detalle.id_butaca);
                    comando.Parameters.AddWithValue("@precio", detalle.precio);
                    comando.Parameters.AddWithValue("@id_descuento", detalle.id_descuento);
                    comando.Parameters.AddWithValue("@id_funcion", detalle.id_funcion);

                    await comando.ExecuteNonQueryAsync();
                    comando.Parameters.Clear();
                }
                t.Commit();

                
            }
            catch
            {
               
                
                t.Rollback();
                
                control = false;
            }
            finally
            {
                Desconectar();
            }
            return control;
        }

        public async Task<int> ConsultaNumero(string nombreSP, string paramSalida)
        {
            SqlParameter pOut = new SqlParameter(paramSalida, SqlDbType.Int);

            Conectar();
            comando.Parameters.Clear();
            comando.CommandText = nombreSP;

            pOut.Direction = ParameterDirection.Output;
            comando.Parameters.Add(pOut);
            await comando.ExecuteNonQueryAsync();
            comando.Parameters.Clear();

            Desconectar();

            return (int)pOut.Value;
        }

        public Usuarios CrearUsuario(string nombreSP, string usuario, string contraseña, string mail)
        {
            Usuarios user = new Usuarios();

            conexion.Open(); // Abre la conexión a la base de datos
            SqlCommand comando = new SqlCommand(); // Crea un objeto para ejecutar comandos SQL
            comando.Connection = conexion; // Establece la conexión para el comando
            comando.CommandType = CommandType.StoredProcedure; // Indica que se utilizará un procedimiento almacenado
            comando.CommandText = nombreSP; // Establece el nombre del procedimiento almacenado a ejecutar
            comando.Parameters.Clear(); // Limpia los parámetros del comando        
            comando.Parameters.AddWithValue("@usuario", usuario);// Agrega los parámetros al comando
            comando.Parameters.AddWithValue("@contraseña", contraseña);// Agrega los parámetros al comando
            comando.Parameters.AddWithValue("mail", mail);// Agrega los parámetros al comando

            using (SqlDataReader reader = comando.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    // Leer el primer registro
                    reader.Read();
                    // Mapear los resultados a un objeto Usuario
                    user.Contraseña = reader["contrasena"].ToString();
                    user.Usuario = reader["nombre_de_usuario"].ToString();
                    user.Usuario = reader["email"].ToString();
                    // Mapear otros campos según sea necesario
                }
            }

            conexion.Close(); // Cierra la conexión a la base de datos

            return user; // Devuelve el DataTable con los resultados obtenidos
        }


        public Usuarios ConsultarUsuarioPorNombre(string nombreSP, string usuario)
        {
            Usuarios user = new Usuarios();

            conexion.Open(); // Abre la conexión a la base de datos
            SqlCommand comando = new SqlCommand(); // Crea un objeto para ejecutar comandos SQL
            comando.Connection = conexion; // Establece la conexión para el comando
            comando.CommandType = CommandType.StoredProcedure; // Indica que se utilizará un procedimiento almacenado
            comando.CommandText = nombreSP; // Establece el nombre del procedimiento almacenado a ejecutar
            comando.Parameters.Clear(); // Limpia los parámetros del comando        
            comando.Parameters.AddWithValue("@usuario", usuario); // Agrega los parámetros al comando

            using (SqlDataReader reader = comando.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    // Leer el primer registro
                    reader.Read();
                    // Mapear los resultados a un objeto Usuario
                    user.Contraseña = reader["contrasena"].ToString();
                    user.Usuario = reader["nombre_de_usuario"].ToString();
                    // Mapear otros campos según sea necesario
                }
            }

            conexion.Close(); // Cierra la conexión a la base de datos

            return user; // Devuelve el DataTable con los resultados obtenidos
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
       

      
      
    }
}
