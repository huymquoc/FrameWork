using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Repository;

namespace Framework.Web.Service
{

    public interface IService : IDisposable
    {

    }

    public class BaseService<T> : IService where T : class
    {
        private readonly IRepository<T> _repository; 

        public BaseService(IUnitOfWork unitOfWork)
        {
            _repository = unitOfWork.Repository<T>();
        }

        protected IRepository<T> Repository {
            get { return _repository; }
        }
        

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
