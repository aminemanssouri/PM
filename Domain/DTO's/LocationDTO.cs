using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Domain.DTO_s
{

    public class LocationDTO
    {
        public int LocationId { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Contact Number is required")]
        [Phone(ErrorMessage = "Invalid phone number format")]
        public string ContactNumber { get; set; } = string.Empty;
    }



}
