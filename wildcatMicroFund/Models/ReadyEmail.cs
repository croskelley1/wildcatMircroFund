using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wildcatMicroFund.Models
{
    public class ReadyEmail
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        [EmailAddress]
        [Required]
        public string? ReadyEmailEmail { get; set; }
        [Required]
        public string? ReadyEmailSubject { get; set; }
        [Required]
        public string? ReadyEmailContent { get; set; }
        [ForeignKey("EmailTemplate")]
        public int EmailTemplateId { get; set; }
        public virtual EmailTemplate EmailTemplate { get; set; }
        [ForeignKey("ApplicationUser")]
        public string UserID { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}
