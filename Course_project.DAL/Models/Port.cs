using System;
using System.Collections.Generic;

#nullable disable

namespace Course_project.DAL.Models
{
    public partial class Port
    {
        public Port()
        {
            PriceLogs = new HashSet<PriceLog>();
        }

        public int PortId { get; set; }
        public string NameOfTerminal { get; set; }
        public string MainAddress { get; set; }
        public string AccurateAddress { get; set; }
        public string Telephone { get; set; }

        public virtual ICollection<PriceLog> PriceLogs { get; set; }
    }
}
