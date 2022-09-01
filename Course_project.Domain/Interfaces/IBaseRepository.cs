using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Course_project.DAL.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<List<T>> GetAll();

        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression);
        Task<bool> Add(T entity);
        Task<bool> AddRange(IEnumerable<T> entities);

        Task<bool> Remove(T entity);
        Task<bool> RemoveRange(T entity);

        Task<T> Update(T entity);

    }
}
