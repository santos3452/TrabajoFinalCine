using CineBack.AccesoDatos;
using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineBack.AccesoDatos;

namespace CineBack.Fachada.Implementacion
{
    internal class AplicationRepository : IAplicationRepository
    {
        public List<Clientes> getconsultarClientes()
        {
            List<Clientes> clientes = new List<Clientes>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_Consultar_Clientes");
            foreach (DataRow r in tabla.Rows)
            {
                //mapeo
                Clientes cliente = new Clientes();
                cliente.id_cliente = Convert.ToInt32(r["id_cliente"].ToString());
                cliente.nom_cliente = (r["nom_cliente"]).ToString();
                cliente.apellido_cliente = (r["apellido_cliente"]).ToString();
                cliente.DNI = Convert.ToInt32(r["DNI"].ToString()); ;
                cliente.telefono = Convert.ToInt32(r["telefono"].ToString());
                cliente.email = (r["email"]).ToString();
                clientes.Add(cliente);
            }
            return clientes;
        }
    }
}
