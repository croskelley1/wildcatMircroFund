using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class Availability
    {
        [Key]
        public int AvailID { get; set; }
        public int UserID { get; set; }
        [Required]
        [Display(Name = "AvailabilityStart")]
        public DateTime AvailStart { get; set; }
        [Required]
        [Display(Name = "AvailabilityEnd")]
        public DateTime AvailEnd { get; set; }
        //AvailDay?
    }
}
