using Microsoft.AspNetCore.Mvc;

namespace CineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CineController : Controller
    {
        [HttpGet("api/cine")]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
