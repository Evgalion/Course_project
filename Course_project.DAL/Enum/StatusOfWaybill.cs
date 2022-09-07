using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_project.Domain.Enum
{
    public enum StatusOfWaybill
    {
        [Display(Name = "В процессе")]
        Ремонт = 1,
        [Display(Name = "Товар получен")]
        Процесс = 2,
        [Display(Name = "Товар отгружен")]
        Отгружен = 3,
        [Display(Name = "Возврат товара")]
        Возврат = 4
    }
}
