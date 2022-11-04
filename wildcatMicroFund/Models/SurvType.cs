using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class SurvType
    {
        [Key]
        public int SurvTypeID { get; set; }
        [Required]
        [Display(Name = "SurveyTypeDescription")]
        public string SurvTypeDesc { get; set; }
    }
}
