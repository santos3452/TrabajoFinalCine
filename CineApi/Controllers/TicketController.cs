using CineBack.services.implementaciones;
using CineBack.services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using System.Net.Sockets;
using CineBack.Fachada;
using CineBack.Fachada.Implementacion;
using CineBack.Entidades;

namespace CineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController: Controller
    {

        private IServicio gestor;

        public TicketController()
        {

            gestor = new Servicio();
        }


        [HttpGet("/FormasDePago")]
        public IActionResult GetFormasDePago()
        {
            return Ok(gestor.getFormaDelPago());
        }

        [HttpGet("/Peliculas")]
        public IActionResult GetPeliculas()
        {
            return Ok(gestor.getPeliculas());
        }


        [HttpGet("/FuncionesPorID")]
        public IActionResult getFuncionesPorID(int id)
        {

            try
            {
                if (id == 0)
                {
                    return BadRequest("error ");
                }
                return Ok(gestor.getFunciones_por_ID(id));
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        [HttpGet("/ButacasPorFuncion")]
        public IActionResult getButacaPorFuncion(int id)
        {

            try
            {
                if (id == 0)
                {
                    return BadRequest("error ");
                }
                return Ok(gestor.GetButacas(id));
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpPost("/InsertarTicket")]
        public async Task<IActionResult> PostTicket(TicketFactura ticket)
        {
            try
            {
                if (ticket == null)
                {
                    return BadRequest("Datos del examen incorrectos!");
                }

                return Ok(await gestor.InsertarTicket(ticket));
            }
            catch
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/ProximoID")]
        public IActionResult getProximoID()
        {
            return Ok(gestor.GetProximoID());
        }






    }
}
