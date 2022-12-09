using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class Application
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Company Name")]
        public String? CompanyName { get; set; }

        public DateTime CreatedDate { get; set; }

        
        [Display(Name = "App Status")]
        public int AppStatus { get; set; }

        // How to get applicant and mentor?

    }
}
