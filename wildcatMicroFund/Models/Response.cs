using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wildcatMicroFund.Models
{
    public class Response
    {
        [Key]
        public int ResponseID { get; set; }
       
        [Display(Name = "Response")]
        public string? Responses { get; set; }

        [ForeignKey("AssignedQuestionId")]
        public int? QuestionID { get; set; }
        
    }
}
