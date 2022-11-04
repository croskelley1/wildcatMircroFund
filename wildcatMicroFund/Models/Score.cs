using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class Score
    {
        [Key]
        public int ScoreID { get; set; }

        public int UserID { get; set; }

        [Display(Name = "Score")]
        [Range(1, 10, ErrorMessage = "Score must be from 1 to 10.")]
        public double ScoreValue { get; set; }

        [Display(Name = "Score Comments")]
        public string? ScoreComments { get; set; }

        [Display(Name = "Pitch Event Application ID")]
        public int PitchEvAppID { get; set; }

        [Display(Name = "Response ID")]
        public int ResponseID { get; set; }
    }
}
