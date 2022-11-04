using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class NoteType
    {
        [Key]
        public int NoteTypeID { get; set; }
        [Required]
        [Display(Name ="NoteTypeDescription")]
        public string? NoteTypeDesc { get; set; }
    }
}
