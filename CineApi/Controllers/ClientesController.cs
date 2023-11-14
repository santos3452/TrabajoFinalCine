using CineBack.services.implementaciones;
using CineBack.services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using CineBack.Entidades;

namespace CineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : Controller
    {
        private IServicio gestor;

        public ClientesController()
        {

            gestor = new Servicio();
        }


        [HttpGet("/ConsultarClientes")]
        public async Task<IActionResult> GetClientes()
        {
            return Ok(gestor.getconsultarClientes());
        }

        [HttpPost("/Consultar")]
        public async Task<IActionResult> GetAllClientes([FromBody] Usuarios user)
        {
            return Ok("El usuario es " + user.Usuario );
        }
    }
}
