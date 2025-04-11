using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO_s
{
    public class CarImagesDTO
    {
        public int carImage { get; set; }
        [Url]
        public string ImageUrl { get; set; } = string.Empty;

    }
}
