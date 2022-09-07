using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Course_project.Domain.Enum
{
    public enum StatusOfContract
    {
        [Display(Name = "В процессе")]
        Ремонт = 1,
        [Display(Name = "Завершён")]
        Завершён = 2,
        [Display(Name = "Отменён")]
        Отменён = 3
    }
}
