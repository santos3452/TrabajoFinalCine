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
        private IAplicacion oDao;

        public Servicio()
        {
            oDao = new Aplicacion();
        }
        public List<Clientes> getconsultarClientes()
        {
            return oDao.getconsultarClientes();

        }





    }
}
