using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Numerics;

namespace AllPropertiesApp.Models
{
    public class User
    {
        public Guid Id { get; set; }
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Length must be between 2 and 100 characters.")]
        public required string Name { get; set; }
        [Column(TypeName = "varchar(200)")]
        [EmailAddress]
        public required string Email { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Money { get; set; }
        [Required]
        public DateOnly DateOfBirth { get; set; }
        public TimeOnly TimeOfBirth { get; set; }
        [Range(0, 999, ErrorMessage = "The value must be between 0 and 999.")]
        public int FavouriteNumber { get; set; }
        public bool IsStudent { get; set; }
        [RegularExpression(@"^[MWN]$", ErrorMessage = "Value must be one of the letters: M, W or N.")]
        [Column(TypeName = "char(1)")]
        public char GenderChar { get; set; }
        [Height("Values of HeightInMeters and HeightInCentimeters must be consistent.")]
        public byte HeightInCentimeters { get; set; }
        public ushort Years { get; set; }
        [Height("Values of HeightInMeters and HeightInCentimeters must be consistent.")]
        public float HeightInMeters { get; set; }
        public double EnergyConsumption { get; set; }
        [Column(TypeName = "bigint")]
        public int BigValue { get; set; }
        public long Value { get; set; }
    }

    public class HeightAttribute : ValidationAttribute
    {
        public HeightAttribute(string errorMessage) : base(errorMessage) { }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var user = (User)validationContext.ObjectInstance;
            int metersInCentimeters = (int)(user.HeightInMeters * 100);

            if (metersInCentimeters != user.HeightInCentimeters)
            {
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
