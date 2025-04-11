using System.ComponentModel.DataAnnotations;

namespace Domain.Model
{
    public class Location
    {
        [Key]
        public int Loction { get; set;  }
        [Required]
        public string? Adderss { get; set; }

        [Required]
        public string? Name { get; set; }
        [Required]
        public string? ContactNumber { get; set; }

        public ICollection<CarLocation> carLocations { get; set; } = new List<CarLocation>();
    }
}
