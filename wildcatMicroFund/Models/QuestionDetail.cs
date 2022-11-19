using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace wildcatMicroFund.Models
{
    public class QuestionDetail
    {
        [Key]
        public int QuestionDetailId { get; set; }

        [Required]
        [Display(Name = "QuestionDetailInfo")]
        public string? QuestionDetailInfo { get; set; }

        [ForeignKey("QuestionID")]
        public virtual Question? Question { get; set; }
    }
}
