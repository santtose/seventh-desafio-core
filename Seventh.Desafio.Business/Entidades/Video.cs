using Seventh.Desafio.Business.Entidades.Base;
using System;

namespace Seventh.Desafio.Business.Entidades
{
    public class Video : Entity
    {
        public Guid ServidorId { get; set; }
        public string Descricao { get; set; }
        public string VideoUpload { get; set; }
        public bool IsRunning { get; set; }

        public Servidor Servidor { get; set; }
    }
}
