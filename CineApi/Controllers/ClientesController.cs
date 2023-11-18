using CineBack.services.implementaciones;
using CineBack.services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using CineBack.Entidades;
using System.Net.Sockets;
using CineBack.Fachada;
using CineBack.Fachada.Implementacion;

namespace CineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : Controller
    {
        private IServicio gestor;
        private IAplicacion a;

        public ClientesController()
        {

            gestor = new Servicio();
            a = new Aplicacion();
        }


        [HttpGet("/ConsultarClientes")]
        public async Task<IActionResult> GetClientes()
        {
            return Ok(gestor.getconsultarClientes());
        }

      

        [HttpDelete("/EliminarCliente")]
        public IActionResult EliminarCliente(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest("error ");
                }
                return Ok(gestor.getEliminarCliente(id));
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpPost("/PostCliente")]
        public IActionResult PostCliente(Clientes cliente)
        {
            try
            {
                if (cliente == null)
                    return BadRequest("Error al dar de alta al cliente.");

                return Ok(gestor.getInsertarCliente(cliente));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpPut("/ActualizarCliente")]
        public IActionResult ActualizarCliente(Clientes cliente)
        {
            try
            {
                if (cliente == null)
                    return BadRequest("ERROR AL DAR DE ALTA EL TICKET");

                return Ok(gestor.getActualizarCliente(cliente));
            }
            catch (Exception e)
            {
                throw e;
            }

          



        }
    }
}
