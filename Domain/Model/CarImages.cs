using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
    public  class CarImages
    {
        [Key]
        public int ImageID { get; set; }

        [Required]
        [Url]
        public string ImageUrl { get; set; } = string.Empty;

        [ForeignKey("Car")]
        public int CarID { get; set; }

        //navigation
        public Car? car { get; set; }




    }
}
