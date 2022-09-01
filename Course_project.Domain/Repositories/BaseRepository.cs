using Course_project.DAL.Interfaces;
using Course_project.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Course_project.DAL.Repositories
{
    // TODO: сделать класс BaseRepository похожим на пример Ярика

    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly Transport_DBContext _DBContext;

        public BaseRepository(Transport_DBContext dBContext)
        {
            _DBContext = dBContext;
        }

        public async Task<bool> Create(T entity)
        {

            await _DBContext.AddAsync(entity);
            await _DBContext.SaveChangesAsync();
            return true;
        }

        public Task<bool> Delete(T entity)
        {
            throw new NotImplementedException();
        }

        //Finds a set of record that matches the passed expression.
        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression)
        {
            return _DBContext.Set<T>().Where(expression);
        }

        public Task<T> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
