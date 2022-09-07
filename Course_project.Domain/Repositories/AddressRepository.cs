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
    public class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        private readonly Transport_DBContext _DBContext;

        public AddressRepository(Transport_DBContext dBContext): base(dBContext)
        {
        }

    }
}
