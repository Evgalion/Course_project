using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_project.Domain.ViewModels.Address
{
    public class AddressViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string MainDestination { get; set; }
        public string AccurateDestination { get; set; }
        public int? NextId { get; set; }
    }
}
