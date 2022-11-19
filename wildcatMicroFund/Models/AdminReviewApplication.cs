using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace wildcatMicroFund.Models
{
    public class AdminReviewApplication
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "App Name")]
        public string? CompanyName { get; set; }

        [Display(Name = "Status")]
        public String? Description { get; set; }

        public int ApplicationId { get; set; }

        public int ApplicationStatusId { get; set; }

        // Connects to Objects or Tables
        [ForeignKey("ApplicationId")]
        public virtual Application? Application { get; set; }

        [ForeignKey("StatusId")]
        public virtual Status? Status { get; set; }

        // [ForeignKey("MentorId")]
        // public virtual UserId? UserId { get; set; }

    }
}
