using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace wildcatMicroFund.Models
{
    public class QCategory
    {

        [Key]
        public int QCategoryID { get; set; }
        [Required]
        [Display(Name = "Question Category")]
        public string QCategoryDesc { get; set; }
    }
}
