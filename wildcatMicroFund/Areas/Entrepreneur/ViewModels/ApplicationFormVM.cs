using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using wildcatMicroFund.Models;
namespace wildcatMicroFund.Areas.Entrepreneur.ViewModels
{
    public class ApplicationFormVM
    {
        public Application? Application { get; set; }
        public List<Question>? Questions { get; set; }
        public string[]? rawResponses { get; set; }
        public List<Response>? Responses { get; set; }
    }
}