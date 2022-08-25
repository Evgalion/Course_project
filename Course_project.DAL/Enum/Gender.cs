using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Course_project.Domain.Enum
{
    public enum Gender
    {
        [Display(Name = "Пшеница")]
        Пшеница = 0,
        [Display(Name = "Кукуруза")]
        Кукуруза = 1,
    }
}
