using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wildcatMicroFund.Models
{
    public class AssignedQuestion
    {

        [Key]
        public int AssignedQuestionId { get; set; }

        public DateTime AppQuestionDate { get; set; }

        [ForeignKey("QuestionId")]
        public virtual Question? Question { get; set; }
        [ForeignKey("ApplicationId")]
        public virtual Application? Application { get; set; }  
    }
}
