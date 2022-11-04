using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class DocumentType
    {
        [Key]
        public int DocTypeID { get; set; }
        [Required]
        [Display(Name = "DocumentTypeDescription")]
        public string? DocTypeDesc { get; set; }
    }
}
