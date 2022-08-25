using Course_project.Domain.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Course_project.Domain.Models
{
    public partial class WC
    {
        public int WaybillId { get; set; }
        public int CarId { get; set; }

        public virtual Car Car { get; set; }
        public virtual Waybill Waybill { get; set; }
    }
}
