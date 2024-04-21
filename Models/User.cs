using System.ComponentModel.DataAnnotations;

namespace AllPropertiesApp.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public decimal Money { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int FavouriteNumber { get; set; }
        public bool IsStudent { get; set; }
        public char GenderChar { get; set; }
    }
}
