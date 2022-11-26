using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class UserApplicationAssignmentType
    {
        [Key]
        public int UserApplicationAssignmentTypeId { get; set; }
        public string? UserApplicationAssignmentDesc { get; set; }
    }
}
