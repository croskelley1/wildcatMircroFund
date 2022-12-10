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
        public int ScoreValue { get; set; }

        [Display(Name = "Score Comments")]
        public string? ScoreComments { get; set; }
        
        //[ForeignKey("PitchEventApplicationId")]
        //public virtual PitchEventApplication PitchEventApplication { get; set; }

        [ForeignKey("AssignedQuestionId")]
        public virtual AssignedQuestion AssignedQuestion { get; set; }
    }
}
