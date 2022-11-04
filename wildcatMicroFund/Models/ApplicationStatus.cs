using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class ApplicationStatus
    {
        [Key]
        public int AppStat { get; set; }
        public int UserID { get; set; }
        public int AppID { get; set; }
        public int StatusID { get; set; }
        [Display(Name = "StatusDate")]
        public DateTime StatusDate { get; set; }


    }
}
