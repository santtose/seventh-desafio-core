using Seventh.Desafio.Business.Entidades;
using Seventh.Desafio.Business.Interfaces.Repository.Base;
using System.Collections.Generic;

namespace Seventh.Desafio.Business.Interfaces.Repository
{
    public interface IServidorRepository : IBaseRepository<Servidor>
    {
        IEnumerable<Servidor> ObterVideosServidor();
    }
}
