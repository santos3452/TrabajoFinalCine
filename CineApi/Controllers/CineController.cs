//using CineBack.Entidades;
//using Microsoft.AspNetCore.Mvc;

//namespace CineApi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CineController : Controller
//    {
//        [HttpGet("api/cine")]
//        public IActionResult Index()
//        {
//            return Ok();
//        }
//    }

//    [HttpPost("verificar")]    //Verificar que el usuario y la contraseña existan para iniciar sesion 
//    public IActionResult VerificarUsuario([FromBody] Usuarios credenciales)
//    {
//        // Aquí deberías realizar la lógica para verificar las credenciales en la base de datos
//        // Puedes utilizar Entity Framework, Dapper, o cualquier otro ORM o consulta directa a la base de datos

//        // Ejemplo básico de verificación
//        if (UsuarioValido(credenciales.Usuario, credenciales.Contraseña))
//        {
//            return Ok("Credenciales válidas");
//        }
//        else
//        {
//            return BadRequest("Credenciales inválidas");
//        }
//    }

//    private bool UsuarioValido(string usuario, string contraseña)
//    {
//        // Aquí deberías implementar la lógica para verificar las credenciales en tu base de datos
//        // Puedes utilizar Entity Framework, Dapper, o cualquier otro ORM o consulta directa a la base de datos
//        // Devuelve true si las credenciales son válidas, de lo contrario, devuelve false
//        // Este método es solo un ejemplo, debes adaptarlo a tu aplicación y base de datos específicas
//        // También, asegúrate de manejar las contraseñas de forma segura, por ejemplo, almacenando hashes en lugar de contraseñas en texto plano
//        // y utilizando sal para mayor seguridad
//        return (usuario == "usuarioEjemplo" && contraseña == "contraseñaEjemplo");
//    }
//}
