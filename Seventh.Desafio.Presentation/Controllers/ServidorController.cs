using AutoMapper;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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

        /// <summary>
        /// Inativa o servidor, tirando das buscas. O mesmo metodo o ativa novamente. Saída simples para remoção e recuperação do
        /// servidor sem precisar criar novas tabelas de reciclagem.
        /// </summary>
        /// param name="IsAtivo" se for false, inativa o servidor
        /// <returns></returns>
        [HttpPost("servers/{id:guid}")]
        public IActionResult InativarServidor(Guid id)
        {
            return Ok(_servidorService.InativarServidor(id));
        }

        [HttpGet("servers")]
        public IActionResult GetAll()
        {
            return Ok(_servidorService.GetServidores());
        }
    }
}
