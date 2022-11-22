using Microsoft.AspNetCore.Mvc.Rendering;
using wildcatMicroFund.Models;

namespace wildcatMicroFund.Areas.Mentor.ViewModels
{
    public class ReviewApplicationVM
    {
        public ApplicationStatus? ReviewApplication { get; set; }
        public Application? Application { get; set; }
        public Status? Status { get; set; }
        public IEnumerable<SelectListItem>? StatusList { get; set; }
    }
}
