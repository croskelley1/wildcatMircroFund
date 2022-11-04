using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class PitchEventApplication
    {
        [Key]
        public int PitchEvAppID { get; set; }
        public int PitchID { get; set; }
        public int UserAppID { get; set; }
    }
}
