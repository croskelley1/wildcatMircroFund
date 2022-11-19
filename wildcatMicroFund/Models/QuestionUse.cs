using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace wildcatMicroFund.Models
{
    public class QuestionUse
    {
        [Key]
        public int QuestionUseID { get; set; }

        public int QuestID { get; set; }
        public int QCategoryID { get; set; }

        [Display(Name = "Point Value")]
        public int QuestPointValue { get; set; }

        [ForeignKey("QuestID")]
        public virtual Question? Question { get; set; }

        [ForeignKey("QCategoryID")]
        public virtual QCategory? QCategory { get; set; }

                
    }

}
