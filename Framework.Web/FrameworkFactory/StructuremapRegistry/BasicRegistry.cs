using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap;
using StructureMap.Graph;
using StructureMap.Configuration.DSL;

namespace Framework.Web.FrameworkFactory.StructuremapRegistry
{
    public class BasicRegistry : Registry
    {
        public BasicRegistry()
        {
            Scan(scanner =>
                {
                    scanner.TheCallingAssembly();
                    
                    scanner.WithDefaultConventions();
                });
        }

    }
}