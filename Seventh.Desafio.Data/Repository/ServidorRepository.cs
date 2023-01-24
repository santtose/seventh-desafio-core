using Microsoft.EntityFrameworkCore;
using Seventh.Desafio.Business.Entidades;
using Seventh.Desafio.Business.Interfaces.Repository;
using Seventh.Desafio.Data.Context;
using Seventh.Desafio.Data.Repository.Base;
using System.Collections.Generic;
using System.Linq;

namespace Seventh.Desafio.Data.Repository
{
    public class ServidorRepository : BaseRepository<Servidor>, IServidorRepository
    {
        public ServidorRepository(ApplicationDbContext context) : base(context) { }

        public IEnumerable<Servidor> ObterVideosServidor()
        {
            return _context.Servidores.AsNoTracking().Include(v => v.Videos).Where(s => s.IsAtivo).OrderByDescending(s => s.DataCriacao);
        }
    }
}
