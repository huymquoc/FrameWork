using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Framework.Web.Domain
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string Name { get; set; }

        public virtual Department Department { get; set; }

    }
}