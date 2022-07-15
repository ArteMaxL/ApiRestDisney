using System.ComponentModel.DataAnnotations;

namespace ApiRestDisney.Models.DataModels
{
    public class Character: BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int Age { get; set; }

        public double Weight { get; set; }

        public String? History { get; set; }

        // TODO: Associate movies or series

    }
}
