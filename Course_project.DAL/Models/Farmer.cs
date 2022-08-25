using System;
using System.Collections.Generic;

#nullable disable

namespace Course_project.DAL.Models
{
    public partial class Farmer
    {
        public Farmer()
        {
            FsContracts = new HashSet<FsContract>();
        }

        public int FarmerId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string PhoneNumber { get; set; }
        public string FarmName { get; set; }
        public string MainAddress { get; set; }
        public string AccurateAddress { get; set; }
        public decimal NumberOfHectares { get; set; }
        public decimal? PercentOfSanity { get; set; }

        public virtual ICollection<FsContract> FsContracts { get; set; }
    }
}
