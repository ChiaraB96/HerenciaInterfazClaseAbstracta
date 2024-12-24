using API.ClaseAbstracta;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaseAbstractaController : ControllerBase
    {
        [HttpGet]

        public string ClaseAbstacata()
        {
            Animal animal = new Gato("Negro");
            Gato gato = new Gato("Negro");
            return gato.ObtenerDistanciaRecorrida();
        }
    }
}
