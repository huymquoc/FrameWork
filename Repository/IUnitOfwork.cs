using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    interface IUnitOfwork
    {
        IRepository<T> Repository<T>() where T : class;
        void Dispose();
        void Save();
        void Dispose(bool disposing);

    }
}
