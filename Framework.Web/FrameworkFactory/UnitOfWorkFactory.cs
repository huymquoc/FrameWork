using Framework.Repository;
using Framework.Web.FrameworkFactory;

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
