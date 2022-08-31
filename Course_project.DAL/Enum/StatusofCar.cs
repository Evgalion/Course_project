using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_project.Domain.Enum
{
    public enum StatusofCar 
    {
       [Display(Name = "На ремонте")]
        На_ремонте = 0,
       [Display(Name = "В процессе")]
        В_процессе = 1
    }
}
