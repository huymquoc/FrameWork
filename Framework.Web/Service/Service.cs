using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Framework.Repository;
using Framework.Web.Domain;

namespace Framework.Web.Service
{
    public interface ILibraryService : IService<Student>
    {
        void DoSomething();

    }

    public class LibraryService : ILibraryService
    {
        public void DoSomething()
        {
            using (var unitOfWork = UnitOfWorkFactory.Get())
            {
                var tmp = unitOfWork.Repository<Student>();

                //TODO:
            }
        }
    }
}