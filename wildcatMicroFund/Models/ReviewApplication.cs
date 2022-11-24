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
        
        public virtual Application? Application { get; set; }

       
        public virtual ApplicationStatus? ApplicationStatus { get; set; }

        
        public virtual Status? Status { get; set; }

    }
}
