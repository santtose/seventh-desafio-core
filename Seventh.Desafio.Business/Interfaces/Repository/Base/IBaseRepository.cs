using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Seventh.Desafio.Business.Interfaces.Repository.Base
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T entity);
        IEnumerable<T> Get(Expression<Func<T, bool>> where, int skip = 0, int take = 25);
        IEnumerable<T> GetAsNoTracking(Expression<Func<T, bool>> where, int skip = 0, int take = 25);
        void Update(T entity);
        void Remove(T entity);
    }
}
