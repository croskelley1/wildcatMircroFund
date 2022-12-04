using wildcatMicroFund.Models;
namespace wildcatMicroFund.Areas.Admin.ViewModels
{
    public class UserEmailVM
    {
        public ApplicationUser User { get; set; }
        public ReadyEmail ReadyEmail { get; set; }
        public EmailTemplate EmailTemplate { get; set; }
    }
}
