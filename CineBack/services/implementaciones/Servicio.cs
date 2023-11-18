﻿using BackEnd.Dominio;
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

        public List<Clientes> getconsultarClientes()
        {
            return oDao.getconsultarClientes();


        }
        public bool getEliminarCliente(int id_cliente)
        {
            return oDao.getEliminarCliente(id_cliente);
        }

        public int getInsertarCliente(Clientes oCliente)
        {
            return oDao.getInsertarCliente(oCliente);
        }

        public bool getActualizarCliente(Clientes oCliente)
        {

            return oDao.getActualizarCliente(oCliente);
        }


        //TICKET

        public List<FormaDePago> getFormaDelPago()
        {
            return oDao.getFormaDelPago();

        }


       public  List<Peliculas> getPeliculas()
        {
            return oDao.GetPeliculas();
        }

       

        List<Funciones> IServicio.getFunciones_por_ID(int codigo_pelicula)
        {
            return oDao.getFunciones_por_ID(codigo_pelicula);
        }
    }
}
