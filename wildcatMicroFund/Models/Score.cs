using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class Score
    {
        [Key]
        public int ScoreId { get; set; }
        public int UserID { get; set; }
        public int PitchEvAppID { get; set; }
        public int ResponseID { get; set; }
        [Required]
        [Display(Name = "ScoreValue")]
        public double ScoreValue { get; set; }
        [Required]
        [Display(Name = "ScoreComments")]
        public string? ScoreComments { get; set; }
    }
}
