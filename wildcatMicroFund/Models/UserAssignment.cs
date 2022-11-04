using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class UserAssignment
    {
        [Key]
        public int UserAppID { get; set; }
        public int UserAppAssignType { get; set; }
        public int UserID { get; set; }
        public int AppID { get; set; }
    }
}
