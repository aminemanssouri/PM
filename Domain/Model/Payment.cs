using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        [Required]
        public string? PaymentMethod { get; set; }

        [Required]
        public string? PaymentStatus { get; set; }

        [ForeignKey("Booking")]

        public int? BookingID { get; set; }

        //navigation

        public Booking? Book { get; set; }
        
    }
}
