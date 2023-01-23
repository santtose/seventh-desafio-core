using Microsoft.AspNetCore.Mvc;
using Seventh.Desafio.Business.DTO;

namespace Seventh.Desafio.Presentation.Controllers
{
    [Route("api/")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        [HttpPost("server/{serverId}/videos")]
        public IActionResult AddVideo(VideoDTO videoDTO)
        {
            return Ok();
        }
    }
}
