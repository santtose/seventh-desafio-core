using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Seventh.Desafio.Business.DTO;
using Seventh.Desafio.Business.Entidades;
using Seventh.Desafio.Business.Interfaces.Services;
using System;
using System.IO;

namespace Seventh.Desafio.Presentation.Controllers
{
    [Route("api/")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        private readonly IVideoService _videoService;
        private readonly IMapper _mapper;

        public VideoController(IVideoService videoService, IMapper mapper)
        {
            _videoService = videoService;
            _mapper = mapper;
        }

        [HttpPost("server/{serverId:guid}/videos")]
        public IActionResult AddVideo([FromForm] VideoDTO videoDTO, Guid serverId)
        {
            return Ok(_videoService.AddVideo(_mapper.Map<Video>(videoDTO), videoDTO.FileUpload, serverId));
        }
    }
}
