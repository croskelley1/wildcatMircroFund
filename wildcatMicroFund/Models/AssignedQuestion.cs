using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wildcatMicroFund.Models
{
    public class AssignedQuestion
    {

        [Key]
        public int AssignedQuestionId { get; set; }

        public DateTime AppQuestionDate { get; set; }

        [ForeignKey("QuestionUseId")]
        public virtual QuestionUse? QuestionUse { get; set; }
        [ForeignKey("ApplicationId")]
        public virtual Application? Application { get; set; }
    }
}