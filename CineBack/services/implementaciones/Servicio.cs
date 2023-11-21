using BackEnd.Dominio;
using CineBack.Entidades;
using CineBack.Fachada;
using CineBack.Fachada.Implementacion;
using CineBack.services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.services.implementaciones
{
    public class Servicio : IServicio
    {
        private IAplicacion oDao;
        

        public Servicio()
        {
            oDao = new Aplicacion();
        }

        //CLIENTES

        public async Task<List<Clientes>> getconsultarClientes()
        {
            return await oDao.getconsultarClientes();


        }
        public async Task<bool> getEliminarCliente(int id_cliente)
        {
            return await oDao.getEliminarCliente(id_cliente);
        }

        public async Task<int> getInsertarCliente(Clientes oCliente)
        {
            return await oDao.getInsertarCliente(oCliente);
        }

        public async Task<bool> getActualizarCliente(Clientes oCliente)
        {

            return await oDao.getActualizarCliente(oCliente);
        }


        //TICKET



        public async  Task<bool> InsertarTicket(TicketFactura Ticket)
        {
            return await oDao.InsertarTicket(Ticket);
        }

        public async Task<List<FormaDePago>> getFormaDelPago()
        {
            return await oDao.getFormaDelPago();

        }


       public  async Task<List<Peliculas>>  getPeliculas()
        {
            return await oDao.GetPeliculas();
        }

       

        public async Task <List<Funciones>>  getFunciones_por_ID(int codigo_pelicula)
        {
            return await oDao.getFunciones_por_ID(codigo_pelicula);
        }

       

        public async Task <List<Butaca>> GetButacas(int codigo_funcion)
        {
            return await oDao.GetButacas(codigo_funcion);
        }

        public async Task<int> GetProximoID()
        {
            return await oDao.GetProximoID();
        }

        // FUNCIONES

        public async Task<List<Salas>> getConsultarSalas()
        {
            return await oDao.getConsultarSalas();
        }
       

        public async Task<bool> getInsertarFunciones(List<Funciones> listaFunciones)
        {
            return await oDao.getInsertarFunciones(listaFunciones);
        }
        public async Task<bool> getEliminarFuncion(int codigo_funcion)
        {
            return await oDao.getEliminarFuncion(codigo_funcion);
        }
        public async Task<List<Funciones>> getConsultarFunciones()
        {
            return await oDao.getConsultarFunciones();
        }

        public async Task<List<Funciones>> getConsultarFuncionesALL()
        {
            return await oDao.getConsultarFuncionesALL();
        }

        
    }
}
