using API.Interfaz;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterfazController : ControllerBase
    {
        [HttpGet]

        public string Interfaz()
        {
            Colibrí colibrí = new Colibrí();
            return colibrí.Moverse();
        }
    }
}
