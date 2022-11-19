using Microsoft.AspNetCore.Mvc.Rendering;
using wildcatMicroFund.Models;

namespace wildcatMicroFund.Areas.Judge.ViewModels
{
    public class PitchCriteriaVM
    {
        public QuestionUse? PitchCriteria { get; set; }
        public IEnumerable<SelectListItem> QuestionList { get; set; }
        public IEnumerable<SelectListItem> QCategory { get; set; }
    }
}
