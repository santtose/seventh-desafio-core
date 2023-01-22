using Seventh.Desafio.Business.DTO;
using Seventh.Desafio.Business.Entidades;
using Seventh.Desafio.Business.Interfaces.Repository;
using Seventh.Desafio.Business.Interfaces.Services;
using System;

namespace Seventh.Desafio.Business.Services
{
    public class ServidorService : IServidorService
    {
        private readonly IServidorRepository _fornecedorRepository;

        public ServidorService(IServidorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        public HttpResponseBase AddServidor(Servidor servidor)
        {
            try
            {
                _fornecedorRepository.Add(servidor);

                return new HttpResponseBase { mensagem = "Servidor criado com sucesso", sucesso = true, tpMensagem = HttpResponseBase.TipoMensagem.Sucesso };
            }
            catch (Exception ex)
            {
                return new HttpResponseBase { mensagem = "Erro ao criar servidor", msgException = ex.Message, sucesso = false, tpMensagem = HttpResponseBase.TipoMensagem.Erro };
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
