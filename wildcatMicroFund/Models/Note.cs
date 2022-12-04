using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public string? NoteCreatorUserId { get; set; }
        [Required]
        [Display(Name = "Note Date")]
        public DateTime CreatedDate { get; set; }
        [ForeignKey("ApplicationId")]
        public virtual Application? Application { get; set; }
        [ForeignKey("NoteTypeId")]
        public virtual NoteType? NoteType { get; set; }
    }
}
