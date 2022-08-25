using System;
using System.Collections.Generic;

#nullable disable

namespace Course_project.DAL.Models
{
    public partial class CarMaintaince
    {
        public int CarMaintainceId { get; set; }
        public int CarDriverId { get; set; }
        public string Comment { get; set; }
        public decimal Costs { get; set; }
        public DateTime StartMaintaince { get; set; }
        public DateTime? EndMaintaince { get; set; }

        public virtual CarDriver CarDriver { get; set; }
    }
}
