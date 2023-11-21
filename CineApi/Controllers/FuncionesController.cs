using CineBack.Entidades;
using CineBack.services.implementaciones;
using CineBack.services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionesController : Controller
    {
        private IServicio gestor;
        public FuncionesController()
        {

            gestor = new Servicio();
        }

        [HttpGet("/Peliculas1")]
        public async Task<IActionResult> GetPeliculas()
        {
            return Ok(await gestor.getPeliculas());
        }

        [HttpGet("/ObtenerSalas")]
        public async Task<IActionResult> GetSalas()
        {
            return Ok(await gestor.getConsultarSalas());
        }

        [HttpPost("/InsertarFunciones")]
        public async Task<IActionResult> PostCliente(List<Funciones> listaFunciones)
        {
            try
            {
                if (listaFunciones == null)
                    return BadRequest("Error al dar de alta al cliente.");

                return Ok(await gestor.getInsertarFunciones(listaFunciones));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpDelete("/EliminarFuncion")]
        public async Task<IActionResult> EliminarCliente(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest("error ");
                }
                return Ok(await gestor.getEliminarFuncion(id));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("/ConsultarFunciones")]
        public async Task<IActionResult> GetFunciones()
        {
            return Ok(await gestor.getConsultarFunciones());
        }

        [HttpGet("/ConsultarFuncionesALL")]
        public async Task<IActionResult> GetFuncionesALL()
        {
            return Ok(await gestor.getConsultarFuncionesALL());
        }

    }
}
