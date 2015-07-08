using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Framework.Repository;
using Framework.Web.Domain;

namespace Framework.Web.Service
{
    public interface IEmployeeService : IService<Student>
    {
        void DoSomething();

    }

    public class EmployeeService : IEmployeeService
    {
        public void DoSomething()
        {
            using (var unitOfWork = UnitOfWorkFactory.Get())
            {
                var employeeRepo = unitOfWork.Repository<Student>();
                //TODO:
            }
        }
    }
}