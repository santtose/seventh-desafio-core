using Microsoft.EntityFrameworkCore;
using Seventh.Desafio.Business.Entidades.Base;
using Seventh.Desafio.Business.Interfaces.Repository.Base;
using Seventh.Desafio.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Seventh.Desafio.Data.Repository.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Entity, new()
    {
        protected readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }        

        public IEnumerable<T> Get(Expression<Func<T, bool>> where, int skip = 0, int take = 25)
        {
            return _context.Set<T>()
                .Where(where)
                .Skip(skip)
                .Take(take)
                .ToList();
        }

        public IEnumerable<T> GetAsNoTracking(Expression<Func<T, bool>> where, int skip = 0, int take = 25)
        {
            return _context.Set<T>()
                .Where(where)
                .AsNoTracking()
                .Skip(skip)
                .Take(take)
                .ToList();
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
