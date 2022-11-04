using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class Document
    {
        [Key]
        public int DocID { get; set; }
        public int AppID { get; set; }
        [Required]
        [Display(Name = "DocumentFile")]
        public string? DocFile { get; set; }
    }
}
