using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Course_project.Domain.Enum
{
    public enum TypeOfProduct
    {
        [Display(Name = "Пшеница")]
        Пшеница = 1,
        [Display(Name = "Кукуруза")]
        Кукуруза = 2,
        [Display(Name = "Подсолнечник")]
        Подсолнечник = 3,
        [Display(Name = "Ячмень")]
        Ячмень = 4,
        [Display(Name = "Соя")]
        Соя = 5
    }
}
