using System.ComponentModel.DataAnnotations;

namespace ApiRestDisney.Models.DataModels
{
    public class Genre: BaseEntity
    {
        [Required (ErrorMessage = "The {0} is required."), StringLength(50)]
        public string Name { get; set; } = string.Empty;

        // TODO: Associate with MovieOrSeries Model

        [Required]
        public ICollection<MovieOrSeries> MovieOrSeries { get; set; } = new HashSet<MovieOrSeries> ();
    }
}
