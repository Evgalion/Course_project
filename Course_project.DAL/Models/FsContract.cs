using System;
using System.Collections.Generic;

#nullable disable

namespace Course_project.DAL.Models
{
    public partial class FsContract
    {
        public FsContract()
        {
            CfWithCps = new HashSet<CfWithCp>();
            WFcs = new HashSet<WFc>();
        }

        public int FsuggentionId { get; set; }
        public int? FarmerId { get; set; }
        public decimal Weight { get; set; }
        public short TotalPrice { get; set; }
        public DateTime Date { get; set; }

        public virtual Farmer Farmer { get; set; }
        public virtual Fsuggention Fsuggention { get; set; }
        public virtual ICollection<CfWithCp> CfWithCps { get; set; }
        public virtual ICollection<WFc> WFcs { get; set; }
    }
}
