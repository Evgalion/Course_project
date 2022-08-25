using System;
using System.Collections.Generic;

#nullable disable

namespace Course_project.Domain.Models
{
    public partial class staff
    {
        public staff()
        {
            Fsuggentions = new HashSet<Fsuggention>();
            Pcontracts = new HashSet<Pcontract>();
        }

        public int StaffId { get; set; }
        public int PositionId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }

        public virtual Position Position { get; set; }
        public virtual ICollection<Fsuggention> Fsuggentions { get; set; }
        public virtual ICollection<Pcontract> Pcontracts { get; set; }
    }
}
