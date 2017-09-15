using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest.Core.Repositories
{
    //using repository pattern with unit of work, because it will always keep the code decoupled and easy to make any changes
    //this is a generic interface that can implemented by concrete repositories related to the business model directly

    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
    }
}
