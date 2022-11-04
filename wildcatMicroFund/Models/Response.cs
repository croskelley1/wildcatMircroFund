using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class Response
    {
        [Key]
        public int ResponseID { get; set; }
        public int SurveyQuestionID { get; set; }
        public int AppID { get; set; }
        [Required]
        [Display(Name = "Response")]
        public string? Responses { get; set; }
    }
}
