using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Framework.Repository
{
    public interface IDbContext : IDisposable
    {
        int SaveChanges();
        IDbSet<T> Set<T>() where T : class;
        //DbEntityEntry Entry(object o);
        //void Dispose();
    }
}
