using Course_project.DAL.Interfaces;
using Course_project.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_project.DAL.Repositories
{
    public class CarRepository :  ICarRepository
    {
        private readonly Transport_DBContext _DBContext;

        public CarRepository(Transport_DBContext dBContext)
        {
            _DBContext = dBContext;
        }
        public async Task<bool> Create(Car entity)
        {
            await _DBContext.AddAsync(entity);
            await _DBContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(Car entity)
        {
            _DBContext.Remove(entity);
            await _DBContext.SaveChangesAsync();
            return true;
        }

        public async Task<Car> Get(int id)
        {
            return await _DBContext.Cars.FirstOrDefaultAsync(x => x.CarId == id);
        }

        public async Task<List<Car>> Select()
        {
            return await _DBContext.Cars.ToListAsync();
        }

        public async Task<Car> Update(Car entity)
        {
            _DBContext.Update(entity);
            await _DBContext.SaveChangesAsync();
            return entity;
        }
    }
}
