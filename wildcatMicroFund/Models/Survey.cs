using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class Survey
    {
        [Key]
        public int SurvID { get; set; }
        public int SurveyQID { get; set; }
        public int AppID { get; set; }
        public int SurvTypeID { get; set; }
    }
}
