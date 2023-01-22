using Seventh.Desafio.Business.DTO;
using Seventh.Desafio.Business.Entidades;
using System;
using System.Threading.Tasks;

namespace Seventh.Desafio.Business.Interfaces.Services
{
    public interface IServidorService
    {
        HttpResponseBase AddServidor(Servidor servidor);
        HttpResponseBase UpdateServidor(Servidor servidor);
    }
}
