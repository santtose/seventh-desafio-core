using Seventh.Desafio.Business.DTO;
using Seventh.Desafio.Business.Entidades;
using Seventh.Desafio.Business.Interfaces.Repository;
using Seventh.Desafio.Business.Interfaces.Services;
using System;

namespace Seventh.Desafio.Business.Services
{
    public class ServidorService : IServidorService
    {
        private readonly IServidorRepository _servidorRepository;

        public ServidorService(IServidorRepository servidorRepository)
        {
            _servidorRepository = servidorRepository;
        }

        public HttpResponseBase AddServidor(Servidor servidor)
        {
            try
            {
                var teste = _servidorRepository.Get(x => x.Id == servidor.Id);
                _servidorRepository.Add(servidor);

                return new HttpResponseBase { mensagem = "Servidor criado com sucesso", sucesso = true, tpMensagem = HttpResponseBase.TipoMensagem.Sucesso };
            }
            catch (Exception ex)
            {
                return new HttpResponseBase { mensagem = "Erro ao criar servidor", msgException = ex.Message, sucesso = false, tpMensagem = HttpResponseBase.TipoMensagem.Erro };
            }
        }

        public HttpResponseBase UpdateServidor(Servidor servidor)
        {
            try
            {
                _servidorRepository.Update(servidor);

                return new HttpResponseBase { mensagem = "Servidor atualizado com sucesso", sucesso = true, tpMensagem = HttpResponseBase.TipoMensagem.Sucesso };
            }
            catch (Exception ex)
            {
                return new HttpResponseBase { mensagem = "Erro ao atualizar servidor", msgException = ex.Message, sucesso = false, tpMensagem = HttpResponseBase.TipoMensagem.Erro };
            }
        }
    }
}
