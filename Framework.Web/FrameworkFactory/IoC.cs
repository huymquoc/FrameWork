using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap;

namespace Framework.Web.FrameworkFactory
{
    public static class IoC
    {
        public static IContainer Container { get; set; }
        static IoC ()
        {
             Container = new Container();
        }
    }
}