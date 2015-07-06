using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Repository
{
    public sealed class RepositoryQuery<T> where T: class
    {
        private readonly Repository<T> _repository;
        private Func<IQueryable<T>, IOrderedQueryable<T>> _orderBy;
        private Expression<Func<T, bool>> _predicate;
        private IList<Expression<Func<T, object>>> _navigationProperties;

        public RepositoryQuery(Repository<T> repository)
        {
            _repository = repository;
        }

        public RepositoryQuery<T> OrderBy(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy)
        {
            _orderBy = orderBy;
            return this;
        }

        public RepositoryQuery<T> Include(IList<Expression<Func<T, object>>> navigationProperties)
        {
            _navigationProperties = navigationProperties;
            return this;
        }

        public RepositoryQuery<T> Include(params Expression<Func<T, object>>[] navigationProperties)
        {
            _navigationProperties = navigationProperties;
            return this;
        }

        public RepositoryQuery<T> Filter(Expression<Func<T, bool>> predicate)
        {
            _predicate = predicate;
            return this;
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _repository.Get(predicate);
        }
    }
}
