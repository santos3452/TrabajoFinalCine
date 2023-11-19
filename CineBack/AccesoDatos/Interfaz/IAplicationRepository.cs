using BackEnd.Dominio;
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
        //CLIENTES
        List<Clientes> getconsultarClientes();
        public bool getEliminarCliente(int id_cliente);
        public int  getInsertarCliente(Clientes oCliente);
        public bool getActualizarCliente(Clientes Cliente);


        //TICKETS
        public Task<bool> InsertarTicket(TicketFactura Ticket);
        List<FormaDePago> getFormaDelPago();
        List<Peliculas> GetPeliculas();
        List<Funciones> getFunciones_por_ID(int codigo_pelicula);
        List<Butaca> GetButacas(int codigo_funcion);
        
    }
}
