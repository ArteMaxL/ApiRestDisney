using System.ComponentModel.DataAnnotations;

namespace ApiRestDisney.Models.DataModels
{
    public class Character: BaseEntity
    {
        [Required (ErrorMessage = "The {0} is required."), StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required (ErrorMessage = "The {0} is required.")]
        public int Age { get; set; }

        public float Weight { get; set; }

        public String? History { get; set; }

        // TODO: Associate movies or series

        [Required]
        public ICollection<MovieOrSeries> MoviesOrSeries { get; set; } = new HashSet<MovieOrSeries> ();

    }
}
