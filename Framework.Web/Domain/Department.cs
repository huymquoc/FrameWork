using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Framework.Web.Domain
{
    public class Department
    {
        public string DepartmentId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

    }
}