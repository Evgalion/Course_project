using Course_project.Domain.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Course_project.Domain.Models
{
    public partial class Waybill
    {
        public Waybill()
        {
            WCs = new HashSet<WC>();
            WFcs = new HashSet<WFc>();
            WPcs = new HashSet<WPc>();
        }

        public int WaybillId { get; set; }
        public int AddressId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<WC> WCs { get; set; }
        public virtual ICollection<WFc> WFcs { get; set; }
        public virtual ICollection<WPc> WPcs { get; set; }
    }
}
