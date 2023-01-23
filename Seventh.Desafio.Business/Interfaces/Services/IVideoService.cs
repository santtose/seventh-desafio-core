using Seventh.Desafio.Business.DTO;
using Seventh.Desafio.Business.Entidades;

namespace Seventh.Desafio.Business.Interfaces.Services
{
    public interface IVideoService
    {
        HttpResponseBase AddVideo(Video video);
        HttpResponseBase UpdateVideo(Video video);
    }
}
