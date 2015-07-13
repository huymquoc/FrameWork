using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;

namespace Framework.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal IDbContext _context;
        internal IDbSet<TEntity> _dbSet;

        public TEntity FindById(object id)
        {
            return _dbSet.Find(id);
        }

        public Repository(IDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> query = _dbSet;
            return query.Where(predicate);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }


        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public RepositoryQuery<TEntity> Query()
        {
            return new RepositoryQuery<TEntity>(this);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
