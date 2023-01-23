using System;
using System.Collections.Generic;

namespace Seventh.Desafio.Business.DTO
{
    public class ServidorDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string IpEndereco { get; set; }
        public int IpPorta { get; set; }
        public bool IsAtivo { get; set; }
        public DateTime DataCriacao { get; set; }
        public IEnumerable<VideoDTO> Videos { get; set; }
    }
}
