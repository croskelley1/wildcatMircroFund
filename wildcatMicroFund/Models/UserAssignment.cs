using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wildcatMicroFund.Models
{
    public class UserAssignment
    {
        [Key]
        public int UserAssignmentID { get; set; }

        [ForeignKey("UserApplicationAssignmentTypeId")]
        public virtual UserApplicationAssignmentType? UserApplicationAssignmentType { get; set; }

        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser? ApplicationUser { get; set; }

        [ForeignKey("ApplicationId")]
        public virtual Application? Application { get; set; }
    }
}
