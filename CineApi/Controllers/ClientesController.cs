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
            return  Ok(await gestor.getconsultarClientes());
        }

      

        [HttpDelete("/EliminarCliente")]
        public async Task<IActionResult> EliminarCliente(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest("error ");
                }
                return Ok(await gestor.getEliminarCliente(id));
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpPost("/PostCliente")]
        public async Task<IActionResult> PostCliente(Clientes cliente)
        {
            try
            {
                if (cliente == null)
                    return BadRequest("Error al dar de alta al cliente.");

                return Ok(await gestor.getInsertarCliente(cliente));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpPut("/ActualizarCliente")]
        public async Task<IActionResult> ActualizarCliente(Clientes cliente)
        {
            try
            {
                if (cliente == null)
                    return BadRequest("ERROR AL DAR DE ALTA EL TICKET");

                return Ok(await gestor.getActualizarCliente(cliente));
            }
            catch (Exception e)
            {
                throw e;
            }

          



        }
    }
}
