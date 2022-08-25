using System;
using System.Collections.Generic;

#nullable disable

namespace Course_project.DAL.Models
{
    public partial class CfWithCp
    {
        public int FsuggentionId { get; set; }
        public int PcontractId { get; set; }

        public virtual FsContract Fsuggention { get; set; }
        public virtual Pcontract Pcontract { get; set; }
    }
}
