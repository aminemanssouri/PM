using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;




 namespace Domain.DTO_s
{

    public class BookingDTO
    {
        public int BookingId { get; set; }

        [Required(ErrorMessage = "Rental start date is required")]
        public DateTime RentalStartDate { get; set; }

        [Required(ErrorMessage = "Rental end date is required")]
        public DateTime RentalEndDate { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalCost { get; set; }

        [Required(ErrorMessage = "Rental status is required")]
        public string RentalStatus { get; set; } = string.Empty;

        public int? UserID { get; set; }
        public int? CarID { get; set; }
        public int? PaymentID { get; set; }
    }

    public class CreateBookingDTO
    {
        [Required(ErrorMessage = "Rental start date is required")]
        public DateTime RentalStartDate { get; set; }

        [Required(ErrorMessage = "Rental end date is required")]
        public DateTime RentalEndDate { get; set; }

        [Required(ErrorMessage = "Total cost is required")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalCost { get; set; }

        [Required(ErrorMessage = "Rental status is required")]
        public string RentalStatus { get; set; } = string.Empty;

        [Required(ErrorMessage = "UserID is required")]
        public int UserID { get; set; }

        [Required(ErrorMessage = "CarID is required")]
        public int CarID { get; set; }

        public int? PaymentID { get; set; } // Optional Payment
    }
    public class BookingDetailDTO
    {
        public int BookingId { get; set; }
        public DateTime RentalStartDate { get; set; }
        public DateTime RentalEndDate { get; set; }
        public decimal TotalCost { get; set; }
        public string RentalStatus { get; set; } = string.Empty;

        public UserDTO? User { get; set; } // Related User Info
        public CarDTO? Car { get; set; }   // Related Car Info
        public PaymentDTO? Payment { get; set; } // Related Payment Info
    }
}
