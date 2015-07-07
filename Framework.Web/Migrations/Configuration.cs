using Framework.Web.Domain;
using System.Collections;
using System.Collections.Generic;

namespace Framework.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Framework.Web.Domain.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Framework.Web.Domain.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var employees = new List<Employee>
            {
                new Employee { Name = "Carson" },
                new Employee { Name = "Meredith" },
                new Employee { Name = "Alonso" },
                new Employee { Name = "Gytis" },
                new Employee { Name = "Peggy" },
                new Employee { Name = "Anand" },
                new Employee { Name = "Barzdukas" },
                new Employee { Name = "Justice" },
            };
            employees.ForEach(s => context.Set<Employee>().AddOrUpdate(p => p.Name, s));
            context.SaveChanges();

            var departments = new List<Department>
            {
                new Department { Name = "Department 1"},
                new Department { Name = "Department 2" }

            };
            departments.ForEach(s => context.Set<Department>().AddOrUpdate(p => p.Name, s));
            context.SaveChanges();
        }
    }
}
