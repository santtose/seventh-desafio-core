using Seventh.Desafio.Business.Entidades.Base;
using System.Collections.Generic;

namespace Seventh.Desafio.Business.Entidades
{
    public class Servidor : Entity
    {
        public string Nome { get; set; }
        public string IpEndereco { get; set; }
        public int IpPorta { get; set; }
        public IEnumerable<Video> Videos { get; set; }
    }
}
