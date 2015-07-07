using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Framework.Repository;

namespace Framework.Web.Domain
{
    public class DataContext : DbContext, IDbContext
    {
        public DataContext()
            : base("CompanyConnection")
        {
            Database.SetInitializer<DataContext>(new CreateDatabaseIfNotExists<DataContext>());

            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;               
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}
