using Microsoft.AspNetCore.Mvc.Rendering;
using wildcatMicroFund.Models;

namespace wildcatMicroFund.Areas.Judge.ViewModels
{
    public class PitchCriteriaVM
    {

        public QuestionUse? PitchCriteria { get; set; }
        public Question? Question { get; set; }
        public QCategory? Category { get; set; }

        public IEnumerable<QuestionDetail> QuestionDetailList { get; set; }
        public IEnumerable<Question> QuestionList { get; set; }
        public IEnumerable<SelectListItem> QCategoryList { get; set; }
    }
}
