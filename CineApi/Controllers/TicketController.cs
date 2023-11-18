using CineBack.services.implementaciones;
using CineBack.services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using System.Net.Sockets;
using CineBack.Fachada;
using CineBack.Fachada.Implementacion;

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


    }
}
