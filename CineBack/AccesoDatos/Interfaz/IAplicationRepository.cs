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
        Task <List<Clientes>> getconsultarClientes();
        Task <bool> getEliminarCliente(int id_cliente);
        Task <int>  getInsertarCliente(Clientes oCliente);
        Task <bool> getActualizarCliente(Clientes Cliente);


        //TICKETS
        Task<bool> InsertarTicket(TicketFactura Ticket);
         Task <List<FormaDePago>> getFormaDelPago();
        Task <List<Peliculas>> GetPeliculas();
        Task <List<Funciones>> getFunciones_por_ID(int codigo_pelicula);
        Task <List<Butaca>> GetButacas(int codigo_funcion);
         Task<int> GetProximoID();


        // FUNCIONES
        Task <List<Salas>> getConsultarSalas();
        Task<bool> getInsertarFunciones(List<Funciones> listaFunciones);
        Task<bool> getEliminarFuncion(int codigo_funcion);
        Task <List<Funciones>> getConsultarFunciones();
        Task <List<Funciones>> getConsultarFuncionesALL();
    }
}
