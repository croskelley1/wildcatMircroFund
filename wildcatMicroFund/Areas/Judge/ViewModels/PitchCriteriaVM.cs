using Microsoft.AspNetCore.Mvc.Rendering;
using wildcatMicroFund.Models;

namespace wildcatMicroFund.Areas.Judge.ViewModels
{
    public class PitchCriteriaVM
    {

        //public QuestionUse? PitchCriteria { get; set; }
        //public IEnumerable<SelectListItem> QuestionList { get; set; }
        //public IEnumerable<SelectListItem> QCategory { get; set; }

        public QuestionUse? PitchCriteria { get; set; }
        public Question? Question { get; set; }
        public QCategory? Category { get; set; }

        public IEnumerable<QuestionDetail> QuestionDetailList { get; set; }
        public IEnumerable<Question> QuestionList { get; set; }
        public IEnumerable<SelectListItem> QCategoryList { get; set; }
        public IEnumerable<QuestionUse> QuestionUseList { get; set; }
    }
}
