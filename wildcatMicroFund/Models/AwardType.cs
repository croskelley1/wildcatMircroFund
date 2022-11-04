using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class AwardType
    {
        [Key]
        public int AwardTypeId { get; set; }
        [Required]
        [Display(Name = "AwardTypeDescription")]
        public string AwardTypeDesc { get; set; }
    }
}
