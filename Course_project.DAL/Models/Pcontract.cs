using System;
using System.Collections.Generic;

#nullable disable

namespace Course_project.DAL.Models
{
    public partial class Pcontract
    {
        public Pcontract()
        {
            CfWithCps = new HashSet<CfWithCp>();
            WPcs = new HashSet<WPc>();
        }

        public int PcontractId { get; set; }
        public int LogId { get; set; }
        public int TotalWeight { get; set; }
        public int OwnPrice { get; set; }
        public int StaffId { get; set; }

        public virtual PriceLog Log { get; set; }
        public virtual staff Staff { get; set; }
        public virtual ICollection<CfWithCp> CfWithCps { get; set; }
        public virtual ICollection<WPc> WPcs { get; set; }
    }
}
