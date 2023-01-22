using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Seventh.Desafio.Business.DTO;
using Seventh.Desafio.Business.Entidades;
using Seventh.Desafio.Business.Interfaces.Services;
using System;

namespace Seventh.Desafio.Presentation.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ServidorController : ControllerBase
    {
        private readonly IServidorService _servidorService;
        private readonly IMapper _mapper;

        public ServidorController(IServidorService servidorService, IMapper mapper)
        {
            _servidorService = servidorService;
            _mapper = mapper;
        }

        [HttpPost("server")]
        public IActionResult AddServidor(Servidor servidor)
        {
            return Ok(_servidorService.AddServidor(servidor));
        }

        [HttpPut("server")]
        public IActionResult UpdadeServidor(ServidorDTO servidorDTO)
        {
            var servidor = _mapper.Map<Servidor>(servidorDTO);
            return Ok(_servidorService.UpdateServidor(servidor));
        }
    }
}
