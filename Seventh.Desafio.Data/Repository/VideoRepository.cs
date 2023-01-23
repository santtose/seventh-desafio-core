using Seventh.Desafio.Business.Entidades;
using Seventh.Desafio.Business.Interfaces.Repository;
using Seventh.Desafio.Data.Context;
using Seventh.Desafio.Data.Repository.Base;

namespace Seventh.Desafio.Data.Repository
{
    public class VideoRepository : BaseRepository<Video>, IVideoRepository
    {
        public VideoRepository(ApplicationDbContext context) : base(context) { }
    }
}
