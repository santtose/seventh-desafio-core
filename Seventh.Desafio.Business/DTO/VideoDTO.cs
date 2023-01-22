using System;

namespace Seventh.Desafio.Business.DTO
{
    public class VideoDTO
    {
        public Guid Id { get; set; }
        public Guid ServidorId { get; set; }
        public string Descricao { get; set; }
        public string VideoUpload { get; set; }
        public bool IsRunning { get; set; }

        public ServidorDTO Servidor { get; set; }
    }
}
