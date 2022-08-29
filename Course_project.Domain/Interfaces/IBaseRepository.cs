using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_project.DAL.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<List<T>> Select();
        Task<bool> Create(T entity);
        Task<bool> Delete(T entity);
        Task<T> Update(T entity);

    }
}
