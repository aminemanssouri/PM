using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Domain.DTO_s
{
    

    public class UserDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Full Name is required")]
        [MaxLength(255, ErrorMessage = "Full Name cannot exceed 255 characters")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Username is required")]
        [MinLength(3, ErrorMessage = "Username must be at least 3 characters")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        [JsonIgnore] // ❌ Hide password in responses
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; } = string.Empty;

        public UserRole Role { get; set; } = UserRole.User; // ✅ Use Enum instead of bool?

        public List<BookingDTO> Books { get; set; } = new List<BookingDTO>();
    }

    public class CreateUserDTO
    {
        [Required(ErrorMessage = "Full Name is required")]
        [MaxLength(255, ErrorMessage = "Full Name cannot exceed 255 characters")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Username is required")]
        [MinLength(3, ErrorMessage = "Username must be at least 3 characters")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; } = string.Empty;

        public UserRole Role { get; set; } = UserRole.User;
    }


    public class UserDetailDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public UserRole Role { get; set; } = UserRole.User;

        public List<BookingDTO> Bookings { get; set; } = new List<BookingDTO>(); // ✅ Only when needed
    }


    // ✅ Define Enum Instead of Using `bool?` for Role
    public enum UserRole
    {
        User,
        Admin
    }

}
