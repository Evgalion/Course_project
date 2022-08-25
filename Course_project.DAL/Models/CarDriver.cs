using Course_project.Domain.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Course_project.DAL.Models
{
    public partial class CarDriver
    {
        public CarDriver()
        {
            CarMaintainces = new HashSet<CarMaintaince>();
        }

        public int CarDriverId { get; set; }
        public int DriverId { get; set; }
        public int CarId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }

        public virtual Car Car { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual ICollection<CarMaintaince> CarMaintainces { get; set; }
    }
}
