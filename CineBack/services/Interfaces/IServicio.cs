using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.services.Interfaces
{
    public interface IServicio
    {
        //clientes
        List<Clientes> getconsultarClientes();
        bool getEliminarCliente(int idCliente);
        int getInsertarCliente(Clientes oCliente);
        public bool getActualizarCliente(Clientes oCliente);
    }

}
