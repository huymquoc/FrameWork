using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap;
using StructureMap.Graph;
using StructureMap.Configuration.DSL;
using Framework.Web.FrameworkFactory.Task;

namespace Framework.Web.FrameworkFactory.StructuremapRegistry
{
    public class TaskRegistry : Registry
    {
        public TaskRegistry()
        {
            Scan(scanner =>
            {
                scanner.AddAllTypesOf<IRunAtInit>();
                scanner.AddAllTypesOf<IRunOnEachRequest>();
            });
        }
    }
}