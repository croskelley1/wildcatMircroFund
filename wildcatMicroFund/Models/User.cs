using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        [Display(Name = "UserFirstName")]
        public string? UserFirst { get; set; }
        [Required]
        [Display(Name = "UserLastName")]
        public string? UserLast { get; set; }
        [Required]
        [Display(Name = "UserStreet1")]
        public string? UserStreet1 { get; set; }
        [Required]
        [Display(Name = "UserStreet2")]
        public string? UserStreet2 { get; set; }
        [Required]
        [Display(Name = "UserCity")]
        public string? UserCity { get; set; }
        [Required]
        [Display(Name = "UserState")]
        public string? UserState { get; set; }
        [Required]
        [Display(Name = "UserEmail")]
        public string? UserEmail { get; set; }
        [Required]
        [Display(Name = "UserSpanishPreference")]
        public bool UserSpanishPref { get; set; }
    }
}
