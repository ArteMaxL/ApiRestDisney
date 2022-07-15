using System.ComponentModel.DataAnnotations;

namespace ApiRestDisney.Models.DataModels
{
    public class User: BaseEntity
    {
        [Required (ErrorMessage = "The {0} is required."), StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required (ErrorMessage = "The {0} is required."), StringLength(100)]
        public string LastName { get; set; } = string.Empty;

        [Required (ErrorMessage = "The {0} is required."), EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required (ErrorMessage = "The {0} is required.")]
        public string Password { get; set; } = string.Empty;
    }
}
