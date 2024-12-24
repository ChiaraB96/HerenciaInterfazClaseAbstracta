using API.Herencia;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HerenciaController : ControllerBase
    {
        [HttpGet]

        public string GetAnimal()
        {
            Animal gato = new Gato();
            gato.especie = "Mamífero";
            gato.Moverse();
            return gato.Moverse();
        }

    }
}
