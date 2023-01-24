using Microsoft.AspNetCore.Http;
using Seventh.Desafio.Business.DTO;
using Seventh.Desafio.Business.Entidades;
using System;

namespace Seventh.Desafio.Business.Interfaces.Services
{
    public interface IVideoService
    {
        HttpResponseBase AddVideo(Video video, IFormFile file, Guid serverId);
        HttpResponseBase UpdateVideo(Video video);
    }
}
