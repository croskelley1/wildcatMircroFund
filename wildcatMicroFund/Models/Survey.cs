using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class Survey
    {
        [Key]
        public int SurveyID { get; set; }
        public int SurveyQID { get; set; }
        public int AppID { get; set; }
        public int SurveyTypeID { get; set; }
    }
}
