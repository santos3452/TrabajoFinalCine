using BackEnd.Dominio;
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
        Task<List<Clientes>> getconsultarClientes();
        Task<bool> getEliminarCliente(int idCliente);
        Task<int> getInsertarCliente(Clientes oCliente);
         Task<bool> getActualizarCliente(Clientes oCliente);



        //Tickets

        
        Task<List<FormaDePago>> getFormaDelPago();
        Task<List<Peliculas>>  getPeliculas();
        Task <List<Funciones>> getFunciones_por_ID(int codigo_pelicula);
         Task<bool> InsertarTicket(TicketFactura Ticket);
        Task<List<Butaca>>  GetButacas(int codigo_funcion);
         Task<int> GetProximoID();

        // Funciones

         Task<List<Salas>> getConsultarSalas();
        Task<bool> getInsertarFunciones(List<Funciones> listaFunciones);
        Task<bool> getEliminarFuncion(int codigo_funcion);
        Task<List<Funciones>> getConsultarFunciones();
        Task<List<Funciones>> getConsultarFuncionesALL();

        

    }

}
