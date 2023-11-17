using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Fachada
{
    public interface IAplicacion
    {

        List<Clientes> getconsultarClientes();
        public bool getEliminarCliente(int id_cliente);
        public int  getInsertarCliente(Clientes oCliente);
        public bool getActualizarCliente(Clientes Cliente);
    }
}
