namespace Seventh.Desafio.Business.DTO
{
    public class HttpResponseBase
    {
        public enum TipoMensagem
        {
            Sucesso = 1,
            Aviso = 2,
            Erro = 3,
        }

        public bool sucesso { get; set; } = true;
        public object mensagem { get; set; }
        public string msgException { get; set; }
        public TipoMensagem tpMensagem { get; set; }
    }
}
