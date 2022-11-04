using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class PitchEvent
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Event Date")]
        public DateTime PitchEventDate { get; set; }
    }
}
