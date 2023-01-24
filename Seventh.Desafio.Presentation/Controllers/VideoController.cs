using Microsoft.AspNetCore.Mvc;
using Seventh.Desafio.Business.DTO;
using System;
using System.IO;

namespace Seventh.Desafio.Presentation.Controllers
{
    [Route("api/")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        [HttpPost("server/{serverId:guid}/videos")]
        public IActionResult AddVideo([FromForm] VideoDTO videoDTO, Guid serverId)
        {
            var imgPrefixo = Guid.NewGuid() + "_";

            var path = Path.Combine(Directory.GetCurrentDirectory(), "UploadedFile", imgPrefixo + videoDTO.FileUpload.FileName);

            if (System.IO.File.Exists(path))
            {
                ModelState.AddModelError(string.Empty, "Já existe um arquivo com este nome!");
            }

            using (var stream = new FileStream(path, FileMode.Create))
            {
                videoDTO.FileUpload.CopyToAsync(stream);
            }

            return Ok();
        }
    }
}
