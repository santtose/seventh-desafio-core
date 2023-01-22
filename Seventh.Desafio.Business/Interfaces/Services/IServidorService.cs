using Seventh.Desafio.Business.DTO;
using Seventh.Desafio.Business.Entidades;
using System;
using System.Threading.Tasks;

namespace Seventh.Desafio.Business.Interfaces.Services
{
    public interface IServidorService : IDisposable
    {
        HttpResponseBase AddServidor(Servidor servidor);
    }
}
