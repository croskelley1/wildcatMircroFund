using Microsoft.AspNetCore.Mvc.Rendering;
using wildcatMicroFund.Models;

namespace wildcatMicroFund.Areas.Judge.ViewModels
{
    public class ScoredAppVM
    {

        public int appID { get; set; }
        public QuestionUse? QuestionUse { get; set; }
        public Question? Question { get; set; }
        public QCategory? Category { get; set; }
        public Application? Application { get; set; }

        public IEnumerable<AssignedQuestion> AssignedQuestions { get; set; }
        public IEnumerable<Score> Score { get; set; }
        

        public IEnumerable<QuestionDetail> QuestionDetailList { get; set; }
        public IEnumerable<Question> QuestionList { get; set; }
        public IEnumerable<SelectListItem> QCategoryList { get; set; }
        public IEnumerable<QuestionUse> QuestionUseList { get; set; }
    }
}
