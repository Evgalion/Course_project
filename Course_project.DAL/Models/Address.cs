using Course_project.Domain.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Course_project.Domain.Models
{
    public partial class Address
    {
        public Address()
        {
            InverseNext = new HashSet<Address>();
            Waybills = new HashSet<Waybill>();
        }

        public int Id { get; set; }
        public string MainDestination { get; set; }
        public string AccurateDestination { get; set; }
        public int? NextId { get; set; }

        public virtual Address Next { get; set; }
        public virtual ICollection<Address> InverseNext { get; set; }
        public virtual ICollection<Waybill> Waybills { get; set; }
    }

   
}
