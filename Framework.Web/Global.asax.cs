using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using StructureMap;
using Framework.Web.FrameworkFactory;
using Framework.Web.FrameworkFactory.StructuremapRegistry;
using StructureMap.Graph;
using Framework.Web.FrameworkFactory.Task;
using System.Data.Entity;

namespace Framework.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {

        public IContainer Container { 
            get
            {
                return HttpContext.Current.Items["_container"] as IContainer; 
            }
            set
            {
                HttpContext.Current.Items["_container"] = value; 
            }     
        }        

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Database.SetInitializer(new MigrateDatabaseToLatestVersion())

            DependencyResolver.SetResolver(new StructuremapDependencyResolver(() => Container ?? IoC.Container));
            IoC.Container.Configure(config =>
            {
               // config.Scan(scan => { scan.WithDefaultConventions(); scan.TheCallingAssembly(); });
                config.AddRegistry(new BasicRegistry());
                config.AddRegistry(new ControllerRegistry());
            });

            using (var container = Container.GetNestedContainer())
            {
                var tasks = container.GetAllInstances<IRunAtInit>();

                foreach (var task in tasks)
                {
                    task.Execute();
                }
            }
        }

        public void Application_BeginRequest()
        {
            using (var container = Container.GetNestedContainer())
            {
                var tasks = container.GetAllInstances<IRunOnEachRequest>();

                foreach (var task in tasks)
                {
                    task.Execute();
                }
            }
        }
    }
}
