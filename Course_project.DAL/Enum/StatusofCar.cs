using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_project.Domain.Enum
{
    public enum StatusOfCar 
    {
       [Display(Name = "В процессе")]
        Процесс = 1,
       [Display(Name = "На ремонте")]
        Ремонт  = 2
    }
}
 