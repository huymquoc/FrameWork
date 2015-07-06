using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity FindById(object id);
        void Update(TEntity entity);
        void Insert(TEntity entity);
        void Delete(TEntity entity);
       // RepositoryQuery
    }
}
