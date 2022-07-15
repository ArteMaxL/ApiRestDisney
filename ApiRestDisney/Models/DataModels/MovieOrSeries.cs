using System.ComponentModel.DataAnnotations;

namespace ApiRestDisney.Models.DataModels
{

    public class MovieOrSeries: BaseEntity
    {
        [Required, StringLength(100)]
        public string Title { get; set; } = string.Empty;

        public Calification Calification { get; set; }

        // TODO: Characters associated

         
    }

    public enum Calification
    {
       One = 1,
       Two = 2,
       Three = 3,
       Four = 4,
       Five = 5
    }
}
