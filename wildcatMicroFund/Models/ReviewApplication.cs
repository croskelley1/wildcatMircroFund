using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace wildcatMicroFund.Models
{
    public class ReviewApplication
    {

        [Key]
        public int Id { get; set; }

        public int ApplicationId { get; set; }

        public int ApplicationStatusId { get; set; }

        public int StatusId { get; set; }

        // Connects to Objects or Tables
        [ForeignKey("ApplicationId")]
        public virtual Application? Application { get; set; }

        [ForeignKey("ApplicationStatusId")]
        public virtual ApplicationStatus ApplicationStatus { get; set; }

        [ForeignKey("StatusId")]
        public virtual Status? Status { get; set; }

    }
}
