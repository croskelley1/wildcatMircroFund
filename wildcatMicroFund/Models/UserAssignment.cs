using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wildcatMicroFund.Models
{
    public class UserAssignment
    {
        [Key]
        public int UserAssignmentID { get; set; }

        [ForeignKey("UserApplicationAssignmentType")]
        public virtual UserApplicationAssignmentType? ApplicationAssignmentType { get; set; }

        [ForeignKey("UserId")]
        public virtual IdentityUser? User { get; set; }

        [ForeignKey("ApplicationId")]
        public virtual Application? Application { get; set; }
    }
}
