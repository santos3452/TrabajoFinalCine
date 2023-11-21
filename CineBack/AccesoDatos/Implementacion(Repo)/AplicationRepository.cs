using CineBack.AccesoDatos;
using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineBack.AccesoDatos;
using System.Reflection.Metadata;
using BackEnd.Dominio;

namespace CineBack.Fachada.Implementacion
{
    public class Aplicacion : IAplicacion
    {   
        
        
        /// <summary>
        /// //////////////////////////////////////////////////////////////CLIENTES
        /// </summary>
        /// <returns></returns>


        public async Task <List<Clientes>> getconsultarClientes()
        {
            List<Clientes> clientes = new List<Clientes>();
            DataTable tabla = await HelperDao.ObtenerInstancia().Consultar("SP_Consultar_Clientes");
            foreach (DataRow r in tabla.Rows)
            {
                //mapeo
                Clientes cliente = new Clientes();
                cliente.id_cliente = Convert.ToInt32(r["id_cliente"].ToString());
                cliente.NOMBRE = (r["nom_cliente"]).ToString();
                cliente.APELLIDO = (r["apellido_cliente"]).ToString();
                cliente.DNI = (long)(r["DNI"]); ; ;
                cliente.TELEFONO = (long)(r["telefono"]); 
                cliente.EMAIL = (r["email"]).ToString();
                clientes.Add(cliente);

            }
            return clientes;
        }

        public async Task<bool> getEliminarCliente(int id_cliente)
        {
            string sp = "SP_Eliminar_Clientes";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@id", id_cliente));
            int afectadas = await HelperDao.ObtenerInstancia().EjecutarSQL(sp, lst);
            return afectadas > 0;

        }

     
        public async Task<int> getInsertarCliente(Clientes Cliente)
        {
            string sp = "SP_Insertar_Cliente";
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@nombre", Cliente.NOMBRE));
            parametros.Add(new Parametro("@apellido", Cliente.APELLIDO));
            parametros.Add(new Parametro("@telefono", Cliente.TELEFONO));
            parametros.Add(new Parametro("@dni", Cliente.DNI));
            parametros.Add(new Parametro("@email", Cliente.EMAIL));

            return await HelperDao.ObtenerInstancia().EjecutarSQL(sp, parametros);

            
            
        }

        public async Task<bool> getActualizarCliente(Clientes Cliente)
        {
            string sp = "SP_Actualizar_Cliente";
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@idCliente", Cliente.id_cliente));
            parametros.Add(new Parametro("@nombre", Cliente.NOMBRE));
            parametros.Add(new Parametro("@apellido", Cliente.APELLIDO));
            parametros.Add(new Parametro("@telefono", Cliente.TELEFONO));
            parametros.Add(new Parametro("@dni", Cliente.DNI));
            parametros.Add(new Parametro("@email", Cliente.EMAIL));
            int afectadas = await HelperDao.ObtenerInstancia().EjecutarSQL(sp, parametros);
            return afectadas != 0;




        }




        /// <summary>
        /// ////////////////////////////////////////////////////////////////TICKETS
        /// </summary>
        /// <returns></returns>


        public async Task<bool> InsertarTicket(TicketFactura Ticket)
        {

            return  await HelperDao.ObtenerInstancia().EjecutarMaestroDetalle("SP_Grabar_TicketFactura", "SP_Gabar_Detalle_Ticket", Ticket);
        }




        async Task<List<FormaDePago>> IAplicacion.getFormaDelPago()
        {
            List<FormaDePago> formas = new List<FormaDePago>();
            DataTable tabla = await HelperDao.ObtenerInstancia().Consultar("SP_Consultar_Formas_Pago");
            foreach (DataRow r in tabla.Rows)
            {
                //mapeo
                FormaDePago forma = new FormaDePago();
                forma.id_formapago = Convert.ToInt32(r["id_forma"]);
                forma.descripcion = r["descripcion"].ToString();

                formas.Add(forma);

            }
            return formas;
        }


       public async Task<List<Peliculas>> GetPeliculas()
        {
            List<Peliculas> peliculas = new List<Peliculas>();
            
            DataTable tabla = await HelperDao.ObtenerInstancia().Consultar("sp_consultar_pelicula");
            foreach (DataRow r in tabla.Rows)
            {
                //mapeo
                Peliculas peli = new Peliculas();
                peli.codigo_pelicula = Convert.ToInt32(r["codigo_pelicula"]);
                peli.nombre_pelicula = r["nombre_pelicula"].ToString();
                peli.codigo_cine = Convert.ToInt32(r["codigo_cine"]);
                peli.director = r["director"].ToString();
                peli.codigo_categoria = Convert.ToInt32(r["codigo_categoria"]);
                peli.codigo_clasificacion = Convert.ToInt32(r["codigo_clasificacion"]);
                //  peli.codigo_formato = Convert.ToInt32(r["codigo_formato"]);
                TimeSpan? duracion = (TimeSpan)r["duracion"];
                peli.duracion = duracion;
               


                peliculas.Add(peli);

            }
            return peliculas;


        }
        public async Task<List<Funciones>> getFunciones_por_ID(int codigo_pelicula)
        {
            string sp = "Sp_Buscar_Funcion_Pelicula";
            List<Funciones> funciones = new List<Funciones>();

            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@id_pelicula", codigo_pelicula));
            DataTable tabla = await HelperDao.ObtenerInstancia().ConsultaFiltros(sp, lst);

            foreach (DataRow r in tabla.Rows)
            {
                //mapeo
                Funciones fun = new Funciones();
                fun.codigo_funcion = Convert.ToInt32(r["codigo_funcion"]);
                fun.codigo_pelicula = Convert.ToInt32(r["codigo_pelicula"]);
                fun.fecha  = (DateTime)(r["fecha"]);
                fun.HoraPeli = r["hora"].ToString();
                fun.precio = Convert.ToInt32(r["precio"]);
                fun.id_sala = Convert.ToInt32(r["id_sala"]);


                funciones.Add(fun);

            }
            return funciones;


        }
        public async Task<List<Butaca>> GetButacas(int codigo_funcion)
        {

            string sp = "Sp_Buscar_Butacas_Funcion";
            List<Butaca> butaca = new List<Butaca>();

            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@id_funcion", codigo_funcion));
            DataTable tabla = await HelperDao.ObtenerInstancia().ConsultaFiltros(sp, lst);

            foreach (DataRow r in tabla.Rows)
            {
                //mapeo
                Butaca but = new Butaca();
                but.id_butaca = Convert.ToInt32(r["id_butaca"]);
                but.numero = Convert.ToInt32(r["numero"]);
                


                butaca.Add(but);

            }
            return butaca;

        }

        public async Task<int> GetProximoID()
        {
            return await HelperDao.ObtenerInstancia().ConsultaNumero("SP_Proximo_Ticket", "@proximoID");
        }


        ///////////////////////////// FUNCIONES
        ///
        public async Task<List<Salas>> getConsultarSalas()
        {
            List<Salas> sala = new List<Salas>();
            DataTable tabla = await HelperDao.ObtenerInstancia().Consultar("SP_Consultar_Salas");
            foreach (DataRow r in tabla.Rows)
            {
                //mapeo
                Salas sal = new Salas();
                sal.id_sala = Convert.ToInt32(r["id_sala"]);
                sal.cantidad_butaca = Convert.ToInt32(r["cantidad_butaca"]);
                sal.codigo_cine = Convert.ToInt32(r["codigo_cine"]);

                sala.Add(sal);

            }
            return sala;

        }

        public async Task<bool> getInsertarFunciones(List<Funciones> listaFunciones)
        {
            string sp = "SP_Insertar_Funcion";
            bool totalFilasInsertadas = false;

            foreach (Funciones f in listaFunciones)
            {
                
                List<Parametro> parametros = new List<Parametro>();
                parametros.Add(new Parametro("@codigo_pelicula", f.codigo_pelicula));
                parametros.Add(new Parametro("@fecha", f.fecha));
           
                parametros.Add(new Parametro("@hora", f.HoraPeli));
                parametros.Add(new Parametro("@precio", f.precio));
                parametros.Add(new Parametro("@id_sala", f.id_sala));

                int filasInsertadas = await HelperDao.ObtenerInstancia().EjecutarSQL(sp, parametros);
                totalFilasInsertadas = true;
            }

            return totalFilasInsertadas;
        }

        public async Task<bool> getEliminarFuncion(int codigo_funcion)
        {
            string sp = "SP_Baja_Funcion";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@id", codigo_funcion));
            int afectadas = await HelperDao.ObtenerInstancia().EjecutarSQL(sp, lst);
            return afectadas > 0;

        }


        public async Task<List<Funciones>> getConsultarFunciones()
        {
            List<Funciones> funciones = new List<Funciones>();
            DataTable tabla =await HelperDao.ObtenerInstancia().Consultar("SP_Consultar_Funciones");
            foreach (DataRow r in tabla.Rows)
            {
                //mapeo
                Funciones f = new Funciones();
                f.codigo_funcion = Convert.ToInt32(r["codigo_funcion"].ToString());
                f.codigo_pelicula = Convert.ToInt32(r["codigo_pelicula"].ToString());
                f.fecha =  (DateTime)(r["fecha"]);
                f.HoraPeli= r["hora"].ToString();
                f.precio = Convert.ToInt32(r["precio"]);
                f.id_sala = Convert.ToInt32(r["id_sala"]);
                funciones.Add(f);

            }
            return funciones;
        }

        public async Task<List<Funciones>> getConsultarFuncionesALL()
        {
            List<Funciones> funciones = new List<Funciones>();
            DataTable tabla =await HelperDao.ObtenerInstancia().Consultar("SP_Consultar_Funciones_ALL");
            foreach (DataRow r in tabla.Rows)
            {
                //mapeo
                Funciones f = new Funciones();
                f.codigo_funcion = Convert.ToInt32(r["codigo_funcion"].ToString());
                funciones.Add(f);
            }
            return funciones;
        }

    }


        





    
}
