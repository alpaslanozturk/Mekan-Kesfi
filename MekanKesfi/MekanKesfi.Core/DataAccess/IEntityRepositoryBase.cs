using MekanKesfi.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MekanKesfi.Core.DataAccess
{
    public interface IEntityRepositoryBase<T> where T: class, IEntity, new()
    {
        Task<T> Get(Expression<Func<T, bool>> filter = null);

        Task<List<T>> GetList(Expression<Func<T, bool>> filter = null);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        IQueryable<T> GenelListe();

        DbSet<T> Set();

    }
}
