using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Domain.Model
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        [Required]
        public DateTime RentalStartDate { get; set; }
        [Required]
        public DateTime RentalEndDate { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalCost { get; set; }
        [Required]
        public string? RentalStatus { get; set; }

        [ForeignKey("User")]
        public int? UserID { get; set; }

        [ForeignKey("Car")]

        public int? CarID { get; set; }

        [ForeignKey("Payment")]

        public int? PaymentID { get; set; }

        //Navigation 
        public User? user { get; set; }
        public Car? car { get; set; }
        public Payment? pay { get; set; }




    }
}
