using System;
using System.Collections.Generic;
using Course_project.DAL.Enum;

#nullable disable

namespace Course_project.DAL.Models
{
    public partial class Fsuggention
    {
        public int SuggentionId { get; set; }
        public int Quality { get; set; }
        public decimal Weight { get; set; }
        public short Price { get; set; }
        public int StaffId { get; set; }

        public TypeofProduct Product { get; set; }
        public virtual staff Staff { get; set; }
        public virtual FsContract FsContract { get; set; }
    }
}
