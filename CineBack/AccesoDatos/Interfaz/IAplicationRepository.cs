using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Fachada
{
    internal interface IAplicationRepository
    {

        List<Clientes> getconsultarClientes();
        public bool getEliminarCliente(int idCliente);
        public int  getInsertarCliente(Clientes oCliente);
    }
}
