using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class SurveyQuestion
    {
        [Key]
        public int SurveyQuestionID { get; set; }
        public int QuestID { get; set; }
        public int SurvID { get; set; }

        [Display(Name = "SurveyQuestionDate")]
        public DateTime SurveyQuestionDate { get; set; }

    }
}
