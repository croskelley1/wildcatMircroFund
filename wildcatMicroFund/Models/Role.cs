using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }
        [Required]
        [Display(Name = "RoleTitle")]
        public string? RoleTitle { get; set; }
    }
}
