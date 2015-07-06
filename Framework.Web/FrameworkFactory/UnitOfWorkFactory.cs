using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Repository;
using Framework.Web.FrameworkFactory;
using StructureMap;
using StructureMap.Graph;
using Framework.Web.FrameworkFactory.Task;


namespace Framework.Web
{
    public class UnitOfWorkFactory 
    {
        public IUnitOfWork Get()
        {
            return IoC.Container.GetInstance<IUnitOfWork>();
        }
    }

    public class UnitOfWorkPerRequest : IRunOnEachRequest
    {
        private readonly IDbContext _dbContext;

        public UnitOfWorkPerRequest(IDbContext context)
        {
            
        }

        public void Execute()
        { 
        
        }
    }
}
