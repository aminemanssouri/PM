using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Domain.Model
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        [Required]
        public string? Model { get; set; }
        [Required]
        public string? Brand { get; set; }
        [Required]
        
        public string? RegistrationNumbet { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string? Color { get; set; }
        [Required]
        public decimal AvailablilitySatatus { get; set; }
        [Required]
        public int Mileage { get; set; }
        [Required]
        public string? FullType { get; set; }
        [Required]
        public string? TransmitionsType { get; set; }

        public ICollection<CarImages> Images { get; set; } = new List<CarImages>();

        [Required]
        public string? CarType { get; set; }
        

        [ForeignKey("CarLocation")]
        public int? CarLocationID { get; set; }

        //Navigation

        public required CarLocation carLocation { get; set; }

        public ICollection<Booking> IBook { get; set; } = new List<Booking>(); 





    }
}
