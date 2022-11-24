using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Question Description")]
        public string? QuestionSummary { get; set; }
                
        [Required]
        [Display(Name = "Active")]
        public bool QuestIsActive { get; set; }// If this is false then this question will no longer show up for assignment with a new QuestionUse
    }
}
