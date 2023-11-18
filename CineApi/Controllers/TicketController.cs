using CineBack.services.implementaciones;
using CineBack.services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using System.Net.Sockets;


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


        //[HttpGet("/ConsultarFormasDePago")]
        //public  IActionResult GetFormasDePago()
        //{
        //    return Ok(gestor.getFormaDePagos());
        //}

        [HttpGet("/FormaDePagos")]
        public async Task<IActionResult> GetPagos()
        {
            return Ok(gestor.getFormasDePago());
        }

    }
}
