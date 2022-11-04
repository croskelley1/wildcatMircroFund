using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Question Description")]
        public string? QuestDesc { get; set; }

        [Required]
        [Display(Name = "Survey Question")]
        public string? SurveyQuestion { get; set; }

        [Required]
        [Display(Name = "Active")]
        public bool QuestIsActive { get; set; }
    }
}
