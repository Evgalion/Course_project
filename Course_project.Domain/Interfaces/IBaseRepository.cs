using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_project.DAL.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        T Get(int id);
        Task<List<T>> GetAll();
        bool Create(T entity);
        bool Delete(int id);
        bool Update(T entity);

    }
}
