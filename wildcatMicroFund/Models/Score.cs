using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wildcatMicroFund.Models
{
    public class Score
    {
        [Key]
        public int ScoreID { get; set; }

        public string? UserID { get; set; }

        [Display(Name = "Score")]
        [Range(1, 10, ErrorMessage = "Score must be from 1 to 10.")]
        public double ScoreValue { get; set; }

        [Display(Name = "Score Comments")]
        public string? ScoreComments { get; set; }
        
        [ForeignKey("PitchEventApplicationId")]
        public virtual PitchEventApplication PitchEventApplication { get; set; }

        [ForeignKey("ResponseId")]
        public virtual Response Response { get; set; }
    }
}
