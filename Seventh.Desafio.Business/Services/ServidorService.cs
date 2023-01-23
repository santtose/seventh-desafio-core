using Seventh.Desafio.Business.DTO;
using Seventh.Desafio.Business.Entidades;
using Seventh.Desafio.Business.Interfaces.Repository;
using Seventh.Desafio.Business.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;

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
                servidor.DataCriacao = DateTime.Now;
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

        public IEnumerable<Servidor> GetServidores()
        {
            var retorno = _servidorRepository.GetAsNoTracking(x => x.IsAtivo).OrderByDescending(x => x.DataCriacao);

            return retorno;
        }

        public HttpResponseBase InativarServidor(Guid id)
        {
            try
            {
                var servidor = _servidorRepository.Get(x => x.Id == id).FirstOrDefault();
                var mensagemRetorno = string.Empty;

                if (servidor != null)
                {
                    servidor.IsAtivo = !servidor.IsAtivo;

                    mensagemRetorno = servidor.IsAtivo ? "Servidor recuperado com sucesso" : "Servidor removido com sucesso";

                    _servidorRepository.Update(servidor);
                }

                return new HttpResponseBase { mensagem = mensagemRetorno, sucesso = true, tpMensagem = HttpResponseBase.TipoMensagem.Sucesso };
            }
            catch (Exception ex)
            {
                return new HttpResponseBase { mensagem = "Erro ao remover servidor", msgException = ex.Message, sucesso = false, tpMensagem = HttpResponseBase.TipoMensagem.Erro };
            }
        }

        public HttpResponseBase VerificarDisponibilidade(Guid id)
        {
            try
            {
                var servidor = _servidorRepository.GetAsNoTracking(x => x.Id == id).FirstOrDefault();
                var mensagemRetorno = string.Empty;

                if (servidor != null)
                    mensagemRetorno = servidor.IsDisponivel ? "Disponível" : "Indisponível";

                return new HttpResponseBase { mensagem = mensagemRetorno, sucesso = true, tpMensagem = HttpResponseBase.TipoMensagem.Sucesso };
            }
            catch (Exception ex)
            {
                return new HttpResponseBase { mensagem = "Erro ao verificar servidor", msgException = ex.Message, sucesso = false, tpMensagem = HttpResponseBase.TipoMensagem.Erro };
            }
        }
    }
}
