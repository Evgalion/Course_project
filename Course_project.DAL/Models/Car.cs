using Course_project.Domain.Models;
using System;
using System.Collections.Generic;
using Course_project.Domain.Enum;

#nullable disable

namespace Course_project.Domain.Models
{
    public partial class Car
    {
        public Car()
        {
            CarDrivers = new HashSet<CarDriver>();
            WCs = new HashSet<WC>();
        }

        public int CarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public DateTime StartOperation { get; set; }

        public StatusofCar Status { get; set; }
        public short LiftingCapacity { get; set; }

        public virtual ICollection<CarDriver> CarDrivers { get; set; }
        public virtual ICollection<WC> WCs { get; set; }
    }
}
