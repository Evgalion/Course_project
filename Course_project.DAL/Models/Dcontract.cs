using System;
using System.Collections.Generic;

#nullable disable

namespace Course_project.DAL.Models
{
    public partial class Dcontract
    {
        public int ContractId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal Salary { get; set; }
        public int DriverId { get; set; }

        public virtual Driver Driver { get; set; }
    }
}
