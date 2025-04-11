using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO_s
{
    public class PaymentDTO
    {
        public int PaymentID { get; set; }

        [Required(ErrorMessage = "Payment date is required")]
        public DateTime PaymentDate { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than zero")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Payment method is required")]
        public PaymentMethod PaymentMethod { get; set; } // ✅ Enum instead of string

        [Required(ErrorMessage = "Payment status is required")]
        public PaymentStatus PaymentStatus { get; set; } // ✅ Enum instead of string

        public int BookingID { get; set; } // ✅ No navigation properties
    }

    public class CreatePaymentDTO
    {
        [Required(ErrorMessage = "Payment date is required")]
        public DateTime PaymentDate { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than zero")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Payment method is required")]
        public PaymentMethod PaymentMethod { get; set; }

        [Required(ErrorMessage = "Payment status is required")]
        public PaymentStatus PaymentStatus { get; set; }

        [Required(ErrorMessage = "Booking ID is required")]
        public int BookingID { get; set; }
    }

    public class PaymentDetailDTO
    {
        public int PaymentID { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public PaymentStatus PaymentStatus { get; set; }

        public BookingDTO? Book{ get; set; } // ✅ Include Booking Details
    }


    public enum PaymentMethod
    {
        CreditCard,
        DebitCard,
        PayPal,
        BankTransfer,
        Cash
    }

    public enum PaymentStatus
    {
        Pending,
        Completed,
        Failed,
        Refunded
    }


}
