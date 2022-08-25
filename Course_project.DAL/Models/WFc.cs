using System;
using System.Collections.Generic;

#nullable disable

namespace Course_project.Domain.Models
{
    public partial class WFc
    {
        public int WaybillId { get; set; }
        public int FsuggentionId { get; set; }

        public virtual FsContract Fsuggention { get; set; }
        public virtual Waybill Waybill { get; set; }
    }
}
