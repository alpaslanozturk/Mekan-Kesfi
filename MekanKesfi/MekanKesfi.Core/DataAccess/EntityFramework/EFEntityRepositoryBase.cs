using MekanKesfi.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MekanKesfi.Core.DataAccess.EntityFramework
{
    public class EFEntityRepositoryBase<TEntity>: IEntityRepositoryBase<TEntity>
        where TEntity: class, IEntity, new()
    {
        private DbContext _context;
        public EFEntityRepositoryBase(DbContext context)
        {
            _context = context;
        }
        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            return await _context.Set<TEntity>().SingleOrDefaultAsync(filter);          
        }

        public async Task<List<TEntity>> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter == null)
            {
                return await _context.Set<TEntity>().ToListAsync();
            }
            else
            {
                return await _context.Set<TEntity>().Where(filter).ToListAsync();
            }
              
        }

        public void Add(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
            _context.SaveChanges();        
        }

        public IQueryable<TEntity> GenelListe()
        {
            return _context.Set<TEntity>().AsQueryable();
        }

        public DbSet<TEntity> Set()
        {
            return _context.Set<TEntity>();
        }
    }
}
