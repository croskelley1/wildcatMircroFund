using Microsoft.AspNetCore.Mvc.Rendering;
using wildcatMicroFund.Models;

namespace wildcatMicroFund.Areas.Admin.ViewModels
{
    public class AdminReviewApplicationVM
    {
        public AdminReviewApplication? AdminReviewApplication { get; set; }
        public IEnumerable<SelectListItem>? ApplicationList { get; set; }
        public IEnumerable<SelectListItem>? StatusList { get; set; }
    }
}
