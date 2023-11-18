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
        
        
        //CLIENTES


        public List<Clientes> getconsultarClientes()
        {
            List<Clientes> clientes = new List<Clientes>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_Consultar_Clientes");
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

        public bool getEliminarCliente(int id_cliente)
        {
            string sp = "SP_Eliminar_Clientes";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@id", id_cliente));
            int afectadas = HelperDao.ObtenerInstancia().EjecutarSQL(sp, lst);
            return afectadas > 0;

        }

     
        public int getInsertarCliente(Clientes Cliente)
        {
            string sp = "SP_Insertar_Cliente";
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@nombre", Cliente.NOMBRE));
            parametros.Add(new Parametro("@apellido", Cliente.APELLIDO));
            parametros.Add(new Parametro("@telefono", Cliente.TELEFONO));
            parametros.Add(new Parametro("@dni", Cliente.DNI));
            parametros.Add(new Parametro("@email", Cliente.EMAIL));

            return HelperDao.ObtenerInstancia().EjecutarSQL(sp, parametros);

            
            
        }

        public bool getActualizarCliente(Clientes Cliente)
        {
            string sp = "SP_Actualizar_Cliente";
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@idCliente", Cliente.id_cliente));
            parametros.Add(new Parametro("@nombre", Cliente.NOMBRE));
            parametros.Add(new Parametro("@apellido", Cliente.APELLIDO));
            parametros.Add(new Parametro("@telefono", Cliente.TELEFONO));
            parametros.Add(new Parametro("@dni", Cliente.DNI));
            parametros.Add(new Parametro("@email", Cliente.EMAIL));
            int afectadas = HelperDao.ObtenerInstancia().EjecutarSQL(sp, parametros);
            return afectadas != 0;



        }

       


        //TICKETS

        List<FormaDePago> IAplicacion.getFormaDelPago()
        {
            List<FormaDePago> formas = new List<FormaDePago>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_Consultar_Formas_Pago");
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


        List<Peliculas> IAplicacion.GetPeliculas()
        {
            List<Peliculas> peliculas = new List<Peliculas>();
            
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_consultar_pelicula");
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

      
    }


        





    
}
