using System.ComponentModel.DataAnnotations;

namespace ApiRestDisney.Models.DataModels
{
    public class Genre: BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        // TODO: Associate with MovieOrSeries Model
    }
}
