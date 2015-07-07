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
    public static class UnitOfWorkFactory 
    {
        public static IUnitOfWork Get()
        {
            return IoC.Container.GetInstance<IUnitOfWork>();
        }
    }

}
