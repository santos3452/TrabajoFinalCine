using CineBack.AccesoDatos;
using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Fachada.Implementacion
{
    internal class Aplicacion : IAplicacion
    {
        public List<Clientes> getconsultarClientes()
        {
            List<Clientes> clientes = new List<Clientes>();
            DataTable dt = HelperDAO.ObtenerInstancia().Consultar("SP_CONSULTAR_CLIENTE");
            foreach (DataRow r in dt.Rows)
            {
                Cliente n = new Cliente();
                n.Id_Cliente = Convert.ToInt32(r["id_cliente"]);
                n.Nombre = (r["nom_cliente"]).ToString();
                n.Apellido = (r["ape_cliente"]).ToString();
                n.Dni = Convert.ToInt64(r["dni_cliente"]);
                n.Calle = (string)(r["calle"]);
                n.Email = (string)(r["email"]);
                n.Telefono = (long)(r["telefono"]);
                n.Altura = (int)(r["altura"]);
                clientes.Add(n);
            }
            return clientes;
        }
    }
}
