using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class Award
    {
        [Key]
        public int AwardId { get; set; }
        public int AppID { get; set; }
        public int AwardTypeID { get; set; }
        [Required]
        [Display(Name = "AwardAmount")]
        public double AwardAmount { get; set; }
        [Required]
        [Display(Name = "AwardDate")]
        public DateTime AwardDate { get; set; }
        public bool WasRecieved { get; set; }

    }
}
