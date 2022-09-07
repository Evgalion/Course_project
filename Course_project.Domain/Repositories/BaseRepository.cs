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

        public async Task<bool> Add(T entity)
        {
            await _DBContext.AddAsync(entity);
            await _DBContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> AddRange(IEnumerable<T> entities)
        {
            await _DBContext.AddRangeAsync(entities);
            await _DBContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Remove(T entity)
        {
            _DBContext.Remove(entity);
            await _DBContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> RemoveRange(T entity)
        {
            _DBContext.Remove(entity);
            await _DBContext.SaveChangesAsync();
            return true;
        }

        //Finds a set of record that matches the passed expression.
        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression)
        {
            return _DBContext.Set<T>().Where(expression);
        }

        public async Task<T> Get(int id)
        {
            return await _DBContext.Set<T>().FirstOrDefaultAsync();
        }

        public async Task<List<T>> GetAll()
        {
            return await _DBContext.Set<T>().ToListAsync();
        }
        public async Task<T> Update(T entity)
        {
            _DBContext.Update(entity);
            await _DBContext.SaveChangesAsync();
            return entity;
        }
    }
}
