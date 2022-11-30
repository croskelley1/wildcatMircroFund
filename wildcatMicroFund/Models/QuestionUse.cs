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

        public int QuestDisplayOrder { get; set; }// Display order for each of the borms
        public bool QuestIsScored { get; set; }// This is true for items that are scored by admin / judges.
        public bool QuestUseIsActive { get; set; }// This will remove the question data item from being assigned

        [Display(Name = "Point Value")]
        public int QuestPointValue { get; set; }// The point value that this will count for

        [ForeignKey("QuestID")]
        public virtual Question? Question { get; set; }

        [ForeignKey("QCategoryID")]
        public virtual QCategory? QCategory { get; set; }

                
    }

}
