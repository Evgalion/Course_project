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
        [Display(Name = "Женщина")]
        Женщина = 1,
        [Display(Name = "Мужчина")]
        Мужчина = 2,
    }
}
