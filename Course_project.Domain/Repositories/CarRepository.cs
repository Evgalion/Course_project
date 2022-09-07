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
    public class CarRepository : BaseRepository<Car>, ICarRepository
    {
        private readonly Transport_DBContext _DBContext;

        public CarRepository(Transport_DBContext dBContext) : base(dBContext)
        {

        }
      
    }
}
