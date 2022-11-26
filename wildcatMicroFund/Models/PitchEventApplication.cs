using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wildcatMicroFund.Models
{
    public class PitchEventApplication
    {
        [Key]
        public int PitchEvAppID { get; set; }

        [ForeignKey("PitchEventId")]
        public virtual PitchEvent? PitchEvent { get; set; }

        [ForeignKey("UserApplicationAssignmentId")]
        public virtual UserAssignment? UserAssignment { get; set; }
    }
}
