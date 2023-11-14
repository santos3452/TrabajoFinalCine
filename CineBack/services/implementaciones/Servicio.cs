using CineBack.Entidades;
using CineBack.Fachada;
using CineBack.Fachada.Implementacion;
using CineBack.services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.services.implementaciones
{
    public class Servicio : IServicio
    {
        private IAplicationRepository oDao;

        public Servicio()
        {
            oDao = new AplicationRepository();
        }

        

        public List<Clientes> getconsultarClientes()
        {
            return oDao.getconsultarClientes();


        }
        public bool getEliminarCliente(int idCliente)
        {
            return oDao.getEliminarCliente(idCliente);
        }

       public int getInsertarCliente(Clientes oCliente)
        {
            return oDao.getInsertarCliente( oCliente);
        }



        



    }
}
