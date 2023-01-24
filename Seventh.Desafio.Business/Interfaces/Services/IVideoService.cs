using Microsoft.AspNetCore.Http;
using Seventh.Desafio.Business.DTO;
using Seventh.Desafio.Business.Entidades;
using System;
using System.Collections.Generic;

namespace Seventh.Desafio.Business.Interfaces.Services
{
    public interface IVideoService
    {
        HttpResponseBase AddVideo(Video video, IFormFile file, Guid serverId);

        IEnumerable<Video> GetVideos(Guid serverId);
    }
}
