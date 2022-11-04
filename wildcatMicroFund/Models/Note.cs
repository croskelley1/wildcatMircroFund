using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class Note
    {
        [Key]
        public int NoteID { get; set; }
        [Required]
        [Display(Name ="NoteContent")]
        public string? NoteContent { get; set; }
        [Required]
        [Display(Name = "NoteVisibility")]
        public int NoteVisibility { get; set; }
        [Required]
        [Display(Name = "NoteInternal")]
        public bool NoteInternal { get; set; }
        [Required]
        [Display(Name = "Note Creator")]
        public int NoteCreator { get; set; }
    }
}
