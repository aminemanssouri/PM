using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
    public class CarLocation
    {
        [Key]
        public int CarLocationID { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        [ForeignKey("Location")]
        public int LocationID { get; set; }

        [ForeignKey("Car")]
        public int? CarID { get; set; }

        //navigation 

        public Location? location { get; set; }

        public Car? Cars { get; set; }

        public ICollection<Car> Icar { get; set; } = new List<Car>();


    }
}
