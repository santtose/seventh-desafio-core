using Microsoft.AspNetCore.Http;
using Seventh.Desafio.Business.DTO;
using Seventh.Desafio.Business.Entidades;
using Seventh.Desafio.Business.Interfaces.Repository;
using Seventh.Desafio.Business.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.IO;
using static Seventh.Desafio.Business.DTO.HttpResponseBase;

namespace Seventh.Desafio.Business.Services
{
    public class VideoService : IVideoService
    {
        private readonly IVideoRepository _videoRepository;

        public VideoService(IVideoRepository videoRepository)
        {
            _videoRepository = videoRepository;
        }

        public HttpResponseBase AddVideo(Video video, IFormFile file, Guid serverId)
        {
            try
            {
                video.ServidorId = serverId;
                UploadVideo(video, file);

                _videoRepository.Add(video);

                return new HttpResponseBase { mensagem = "Video criado com sucesso", sucesso = true, tpMensagem = TipoMensagem.Sucesso };
            }
            catch (Exception ex)
            {
                return new HttpResponseBase { mensagem = "Erro ao salvar video", msgException = ex.Message, sucesso = false, tpMensagem = TipoMensagem.Erro};
            }
        }

        public IEnumerable<Video> GetVideos(Guid serverId)
        {
            return _videoRepository.GetAsNoTracking(x => x.ServidorId == serverId);
        }

        private void UploadVideo(Video video, IFormFile file)
        {
            var videoPrefixo = Guid.NewGuid() + "_";
            video.VideoUpload = String.Concat(videoPrefixo, file.FileName);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "UploadedFile", videoPrefixo + file.FileName);            

            //if (System.IO.File.Exists(path))
            //{

            //}

            using (var stream = new FileStream(path, FileMode.Create))
            {
                file.CopyToAsync(stream);
            }
        }
    }
}
