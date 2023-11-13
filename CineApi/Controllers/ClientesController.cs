﻿using CineBack.services.implementaciones;
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





    }
}