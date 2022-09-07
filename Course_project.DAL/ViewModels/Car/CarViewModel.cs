using Course_project.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_project.Domain.ViewModels.Car
{
    public class CarViewModel
    {
        [Required]
        public int CarId { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public DateTime Year { get; set; }
        [Required]
        [Display(Name = "")]
        public string Status { get; set; }
        [Required]
        public short LiftingCapacity { get; set; }
    }
}
