using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace Repository
{
    public class UnitOfWork : IUnitOfwork
    {
        private readonly IDbContext _dbContext;
        private Hashtable _repositories;

        public UnitOfWork()
        {
           // _dbContext = new Frame
        }

        public UnitOfWork(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IRepository<T> Repository<T>() where T : class
        {
            if (_repositories == null)
                _repositories = new Hashtable();

            var concreteType = typeof (T).Name;
            if (!_repositories.ContainsKey(concreteType))
            {
                var atype = typeof (Repository<>);
                var repoInstance = Activator.CreateInstance(atype.MakeGenericType(typeof (T)));
                _repositories.Add(concreteType, repoInstance);
            }

            return _repositories[concreteType] as IRepository<T>;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose(bool disposing)
        {
            throw new NotImplementedException();
        }
    }
}
