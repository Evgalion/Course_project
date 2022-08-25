using System;
using System.Collections.Generic;

#nullable disable

namespace Course_project.Domain.Models
{
    public partial class WPc
    {
        public int WaybillId { get; set; }
        public int PcontractId { get; set; }

        public virtual Pcontract Pcontract { get; set; }
        public virtual Waybill Waybill { get; set; }
    }
}
