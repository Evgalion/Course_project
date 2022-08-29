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
    public class AddressRepository : IAddressRepository
    {
        private readonly Transport_DBContext _DBContext;

        public AddressRepository(Transport_DBContext dBContext)
        {
            _DBContext = dBContext;
        }

        public async Task<bool> Create(Address entity)
        {
          await _DBContext.AddAsync(entity);
          await _DBContext.SaveChangesAsync();
          return true;
        }

        public async Task<bool> Delete(Address entity)
        {
            _DBContext.Remove(entity);
            await _DBContext.SaveChangesAsync();
            return true;
        }

        public async Task<Address> Get(int id)
        {
            return await _DBContext.Addresses.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Address>> Select()
        {
            return await _DBContext.Addresses.ToListAsync();
        }

        //delete this sh*t
        public async Task<Address> GetByName(string name)
        {
            return await _DBContext.Addresses.FirstOrDefaultAsync(x => x.MainDestination == name);
        }

        public async Task<Address> Update(Address entity)
        {
            _DBContext.Update(entity);
            await _DBContext.SaveChangesAsync();
            return entity;
        }
    }
}
