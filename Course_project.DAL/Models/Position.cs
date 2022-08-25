using System;
using System.Collections.Generic;

#nullable disable

namespace Course_project.Domain.Models
{
    public partial class Position
    {
        public Position()
        {
            staff = new HashSet<staff>();
        }

        public int PositionId { get; set; }
        public string Pname { get; set; }
        public decimal? Salary { get; set; }

        public virtual ICollection<staff> staff { get; set; }
    }
}
