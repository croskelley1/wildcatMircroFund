using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class SurveyType
    {
        [Key]
        public int SurveyTypeID { get; set; }
        [Required]
        [Display(Name = "SurveyTypeDescription")]
        public string SurveyTypeDesc { get; set; }
    }
}
