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

namespace CineBack.Fachada.Implementacion
{
    internal class Aplicacion : IAplicacion
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

        public bool getEliminarCliente(int IDCliente)
        {
            string sp = "SP_Eliminar_Cliente";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@id", IDCliente));
            int afectadas = HelperDao.ObtenerInstancia().EjecutarSQL(sp, lst);
            return afectadas > 0;

        }
        public int getInsertarCliente(Clientes Cliente)
        {
            string sp = "SP_Insertar_Cliente";
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@nombre", Cliente.NOMBRE));
            parametros.Add(new Parametro("@apellido", Cliente.APELLIDO));
            parametros.Add(new Parametro("@dni", Cliente.DNI));
            parametros.Add(new Parametro("@email", Cliente.EMAIL));
             parametros.Add(new Parametro("@telefono", Cliente.TELEFONO));

            return HelperDao.ObtenerInstancia().EjecutarSQL(sp, parametros);



        }
}
}
