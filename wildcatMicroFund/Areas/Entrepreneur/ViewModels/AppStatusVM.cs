using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using wildcatMicroFund.Models;
namespace wildcatMicroFund.Areas.Entrepreneur.ViewModels
{
    /// <summary>
    /// Still needs to be implemented, will take care of soon...
    /// </summary>
    public class AppStatusVM
    {
        public IEnumerable<Application>? applications { get; set; }
        public IEnumerable<UserAssignment>? userAssignments { get; set; }
        public IEnumerable<SelectListItem>? statusDesc { get; set; }
    }
}
