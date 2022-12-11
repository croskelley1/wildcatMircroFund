using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using wildcatMicroFund.Models;
namespace wildcatMicroFund.Areas.Entrepreneur.ViewModels
{
    public class ApplicationFormVM
    {
        public Application? Application { get; set; }
        public IEnumerable<Question>? Questions { get; set; }
        public IEnumerable<QCategory>? QCategories { get; set; }
        public IEnumerable<QuestionDetail>? QuestionDetails { get; set; }
        public IEnumerable<QuestionUse>? QuestionUses { get; set; }
    }
}