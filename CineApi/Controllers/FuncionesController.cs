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
        public IActionResult GetPeliculas()
        {
            return Ok(gestor.getPeliculas());
        }

        [HttpGet("/ObtenerSalas")]
        public IActionResult GetSalas()
        {
            return Ok(gestor.getConsultarSalas());
        }

        [HttpPost("/InsertarFunciones")]
        public IActionResult PostCliente(List<Funciones> listaFunciones)
        {
            try
            {
                if (listaFunciones == null)
                    return BadRequest("Error al dar de alta al cliente.");

                return Ok(gestor.getInsertarFunciones(listaFunciones));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpDelete("/EliminarFuncion")]
        public IActionResult EliminarCliente(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest("error ");
                }
                return Ok(gestor.getEliminarFuncion(id));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("/ConsultarFunciones")]
        public async Task<IActionResult> GetClientes()
        {
            return Ok(gestor.getConsultarFunciones());
        }

    }
}
