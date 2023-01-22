using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Seventh.Desafio.Business.Entidades;
using Seventh.Desafio.Business.Interfaces.Services;

namespace Seventh.Desafio.Presentation.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ServidorController : ControllerBase
    {
        private readonly IServidorService _servidorService;

        public ServidorController(IServidorService servidorService)
        {
            _servidorService = servidorService;
        }

        [HttpPost]
        public IActionResult AddServidor(Servidor servidor)
        {
            return Ok(_servidorService.AddServidor(servidor));
        }
    }
}
