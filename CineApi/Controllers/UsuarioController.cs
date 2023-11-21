using CineBack.Entidades;
using Microsoft.AspNetCore.Mvc;
﻿using CineBack.services.implementaciones;
using CineBack.services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using CineBack.Entidades;
using CineBack.AccesoDatos.Implementacion_Repo_;
using CineBack.AccesoDatos;
using System.Text;
using System.Net.Http;
using System.Collections.Specialized;

namespace CineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {

        private IUsuarioService service;

        public UsuarioController(IUsuarioService _service)
        {
            service = _service;
        }


        [HttpPost("Auth")]
        public async Task<ActionResult<bool>> Login([FromBody] Usuarios credenciales)
        {
            //Verificar que el usuario y la contraseña sean correctos para iniciar sesion 
            string result = "";
            bool resultado = false;

            if (credenciales != null)
            {
                resultado = await service.Login(credenciales);
            }

            // Si el resultado es true, entonces es valido para iniciar sesion
            if (resultado)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest("Credenciales inválidas");
            }

        }
        [HttpPost("creation")]
        public async Task<ActionResult<bool>> Start([FromBody] Usuarios creacion)
        {
            //Verificar que el usuario y la contraseña sean correctos para Crear Usuario
            string result = "";
            bool resultado = false;

            if (creacion != null)
            {
                resultado = await service.Start(creacion);
            }

            // Si el resultado es true, entonces es valido para Crear Usuario
            if (resultado)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest("Credenciales inválidas");
            }

        }
    }
}
