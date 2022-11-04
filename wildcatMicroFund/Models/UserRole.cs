using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class UserRole
    {
        [Key]
        public int URID { get; set; }
        int UserID { get; set; }
        int RoleID { get; set; }
    }
}
