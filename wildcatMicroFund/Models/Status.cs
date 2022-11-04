using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class Status
    {
        [Key]
        public int StatusID { get; set; }
        [Required]
        [Display(Name ="StatusDescription")]
        public string? StatusDesc { get; set; }
    }
}
