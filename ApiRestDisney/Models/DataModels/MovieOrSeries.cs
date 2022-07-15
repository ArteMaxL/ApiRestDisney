using System.ComponentModel.DataAnnotations;

namespace ApiRestDisney.Models.DataModels
{

    public class MovieOrSeries: BaseEntity
    {
        [Required (ErrorMessage = "The {0} is required."), StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Range(1,5, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Calification { get; set; }

        public int GenreId { get; set; }


        // TODO: Characters associated

        [Required]
        public ICollection<Character> Characters { get; set; } = new HashSet<Character>();

        [Required]
        public virtual Genre Genre { get; set; } = new Genre();
    }
}
