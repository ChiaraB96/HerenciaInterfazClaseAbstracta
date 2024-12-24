using API.Interfaz;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterfazDosController : ControllerBase
    {
        [HttpGet]
        [Route("api/InterfazDos")]

        public string InterfazDos()
        {
            Interfaz.Base _base = new Base();
            Ballena ballena = new Ballena();
            return _base.Moverse(ballena);
        }

        [HttpGet]
        [Route("api/InterfazDosImplementacion")]

        public string InterfazDosImplementacion()
        {
            IAnimal Ballena = new Ballena();
            return Ballena.ObtenerDistanciaRecorrida();
        }
    }
}
