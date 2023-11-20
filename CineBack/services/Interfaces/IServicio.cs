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
        List<Clientes> getconsultarClientes();
        bool getEliminarCliente(int idCliente);
        int getInsertarCliente(Clientes oCliente);
        public bool getActualizarCliente(Clientes oCliente);



        //Tickets

        
        List<FormaDePago> getFormaDelPago();
        List<Peliculas> getPeliculas();
        List<Funciones> getFunciones_por_ID(int codigo_pelicula);
        public Task<bool> InsertarTicket(TicketFactura Ticket);
        List<Butaca> GetButacas(int codigo_funcion);
        public Task<int> GetProximoID();

        // Funciones

        public List<Salas> getConsultarSalas();
        public bool getInsertarFunciones(List<Funciones> listaFunciones);
        public bool getEliminarFuncion(int codigo_funcion);
        public List<Funciones> getConsultarFunciones();

    }

}
