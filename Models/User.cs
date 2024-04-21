using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace AllPropertiesApp.Models
{
    public class User
    {
        public Guid Id { get; set; }
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Length must be between 2 and 100 characters.")]
        public required string Name { get; set; }
        [EmailAddress]
        public required string Email { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Money { get; set; }
        [Required]
        public DateOnly DateOfBirth { get; set; }
        [Range(0, 999, ErrorMessage = "The value must be between 0 and 999.")]
        public int FavouriteNumber { get; set; }
        public bool IsStudent { get; set; }
        [RegularExpression(@"^[MWN]$", ErrorMessage = "Value must be one of the letters: M, W or N.")]
        public char GenderChar { get; set; }
    }
}
