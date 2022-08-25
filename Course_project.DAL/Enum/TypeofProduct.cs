using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Course_project.DAL.Enum
{
    public enum TypeofProduct
    {
        [Display(Name = "Пшеница")]
        Пшеница = 0,
        [Display(Name = "Кукуруза")]
        Кукуруза = 1,
        [Display(Name = "Подсолнечник")]
        Подсолнечник = 2,
        [Display(Name = "Ячмень")]
        Ячмень = 3,
        [Display(Name = "Соя")]
        Соя = 4
    }
}
