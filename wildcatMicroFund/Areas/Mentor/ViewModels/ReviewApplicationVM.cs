using Microsoft.AspNetCore.Mvc.Rendering;
using wildcatMicroFund.Models;

namespace wildcatMicroFund.Areas.Mentor.ViewModels
{
    public class ReviewApplicationVM
    {
        public ReviewApplication? ReviewApplication { get; set; }
        public IEnumerable<SelectListItem>? ApplicationList { get; set; }
        public IEnumerable<SelectListItem>? StatusList { get; set; }
    }
}
