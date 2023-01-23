using Microsoft.AspNetCore.Http;
using System;
using System.Text.Json.Serialization;

namespace Seventh.Desafio.Business.DTO
{
    public class VideoDTO
    {
        public Guid Id { get; set; }
        public Guid ServidorId { get; set; }
        public string Descricao { get; set; }
        public IFormFile FileUpload { get; set; }
        public string VideoUpload { get; set; }
        public bool IsRunning { get; set; }

        [JsonIgnore]
        public ServidorDTO Servidor { get; set; }
    }
}
