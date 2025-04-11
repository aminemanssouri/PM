
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Domain.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string? FullName { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public required string Username { get; set; }

        [Required]
        [PasswordPropertyText]
        public required string Password { get; set; }

        [Required]
        public string? Address { get; set; }

        public bool ? Role { get; set; }

        public ICollection<Booking> Book { get; set; } = new List<Booking>();

    }
}
