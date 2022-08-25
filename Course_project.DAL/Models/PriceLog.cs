using System;
using System.Collections.Generic;

#nullable disable

namespace Course_project.Domain.Models
{
    public partial class PriceLog
    {
        public PriceLog()
        {
            Pcontracts = new HashSet<Pcontract>();
        }

        public int LogId { get; set; }
        public int Quality { get; set; }
        public short Price { get; set; }
        public int MaxWeight { get; set; }
        public DateTime Deadline { get; set; }
        public int PortId { get; set; }

        public virtual Port Port { get; set; }
        public virtual ICollection<Pcontract> Pcontracts { get; set; }
    }
}
