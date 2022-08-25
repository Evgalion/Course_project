using System;
using System.Collections.Generic;

#nullable disable

namespace Course_project.DAL.Models
{
    public partial class Driver
    {
        public Driver()
        {
            CarDrivers = new HashSet<CarDriver>();
            Dcontracts = new HashSet<Dcontract>();
        }

        public int DriverId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<CarDriver> CarDrivers { get; set; }
        public virtual ICollection<Dcontract> Dcontracts { get; set; }
    }
}
