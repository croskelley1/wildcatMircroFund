using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wildcatMicroFund.Models
{
    public class ApplicationStatus
    {
        [Key]
        public int AppStatId { get; set; }
        public int UserID { get; set; }

        public int ApplicationId { get; set; }
        
        [Display(Name = "StatusDate")]
        public DateTime StatusDate { get; set; }

        // Connects to Objects or Tables
        [ForeignKey("ApplicationId")]
        public virtual Application? Application { get; set; }

        [ForeignKey("StatusId")]
        public virtual Status? Status { get; set; }


    }
}
