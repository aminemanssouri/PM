using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO_s
{

    public class CarDTO
    {
        public int CarId { get; set; }

        [Required(ErrorMessage = "Model is required")]
        public string Model { get; set; } = string.Empty;

        [Required(ErrorMessage = "Brand is required")]
        public string Brand { get; set; } = string.Empty;

        [Required(ErrorMessage = "Registration number is required")]
        public string RegistrationNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Year is required")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Color is required")]
        public string Color { get; set; } = string.Empty;

        [Required(ErrorMessage = "Availability status is required")]
        public bool AvailabilityStatus { get; set; } // ✅ Changed to bool

        [Required(ErrorMessage = "Mileage is required")]
        public int Mileage { get; set; }
         

        [Required(ErrorMessage = "Fuel type is required")]
        public FuelType FuelType { get; set; } // ✅ Enum instead of string

        [Required(ErrorMessage = "Transmission type is required")]
        public TransmissionType TransmissionType { get; set; } // ✅ Enum instead of string

        [Required(ErrorMessage = "Car type is required")]
        public string? CarType { get; set; } // ✅ Enum instead of string

        public int? CarLocationID { get; set; } // Foreign Key (No Navigation Property)

        public List<CarImagesDTO> CarImages { get; set; } = new List<CarImagesDTO>();
    }

    public class CreateCarDTO
    {
        [Required(ErrorMessage = "Model is required")]
        public string Model { get; set; } = string.Empty;

        [Required(ErrorMessage = "Brand is required")]
        public string Brand { get; set; } = string.Empty;

        [Required(ErrorMessage = "Registration number is required")]
        public string RegistrationNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Year is required")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Color is required")]
        public string Color { get; set; } = string.Empty;

        [Required(ErrorMessage = "Availability status is required")]
        public bool AvailabilityStatus { get; set; }

        [Required(ErrorMessage = "Mileage is required")]
        public int Mileage { get; set; }

        [Required(ErrorMessage = "Fuel type is required")]
        public FuelType FuelType { get; set; }

        [Required(ErrorMessage = "Transmission type is required")]
        public TransmissionType TransmissionType { get; set; }

        [Required(ErrorMessage = "Car type is required")]
        public string? CarType { get; set; }

        [Required(ErrorMessage = "Car location is required")]
        public int CarLocationID { get; set; } // Foreign Key
        public List<CarImagesDTO> CarImages { get; set; } = new List<CarImagesDTO>();
    }


    public class CarDetailDTO
    {
        public int CarId { get; set; }
        public string Model { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string RegistrationNumber { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Color { get; set; } = string.Empty;
        public bool AvailabilityStatus { get; set; }
        public int Mileage { get; set; }
        public FuelType FuelType { get; set; }
        public TransmissionType TransmissionType { get; set; }
        public string? CarType { get; set; }

        public CarLocationDTO? CarLocation { get; set; } // ✅ Include Car Location Details

        public List<CarImagesDTO> CarImages { get; set; } = new List<CarImagesDTO>();
    }



    public enum FuelType
    {
        Petrol,
        Diesel,
        Electric,
        Hybrid
    }

    public enum TransmissionType
    {
        Manual,
        Automatic
    }

  

}
