using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Domain.DTO_s
{

    public class CarLocationDTO
    {
        public int CarLocationID { get; set; }

        [Required(ErrorMessage = "Date Added is required")]
        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "Location ID is required")]
        public int LocationID { get; set; }

        public int? CarID { get; set; } // Optional, as it can be null
    }

    

   public class CreateCarLocationDTO
    {
        [Required(ErrorMessage = "Date Added is required")]
        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "Location ID is required")]
        public int LocationID { get; set; }

        public int? CarID { get; set; } // Optional, as it can be null
    }


    public class CarLocationDetailDTO
    {
        public int CarLocationID { get; set; }
        public DateTime DateAdded { get; set; }
        public int LocationID { get; set; }
        public int? CarID { get; set; }

        public LocationDTO? Location { get; set; } // Assuming a LocationDTO exists
        public CarDTO? Car { get; set; }           // Assuming a CarDTO exists
    }



}
