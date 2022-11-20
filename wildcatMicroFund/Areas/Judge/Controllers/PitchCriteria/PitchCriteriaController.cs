using Microsoft.AspNetCore.Mvc;
using wildcatMicroFund.Interfaces;
using wildcatMicroFund.Models;
using wildcatMicroFund.Areas.Judge.ViewModels;


[Area("Judge")]
public class PitchCriteriaController : Controller
{

    private readonly IUnitOfWork _unitOfWork;
    public PitchCriteriaVM PitchJudgeCriteriaList { get; set; }

    public PitchCriteriaController(IUnitOfWork unitOfWork)//Dependency Injection
    {
        _unitOfWork = unitOfWork;
    }

    public ViewResult PitchCriteria()
    {
        var qdList = _unitOfWork.QuestionDetail.List(null, null, "Question");
        var questions = _unitOfWork.Question.List();
        var QCategories = _unitOfWork.QCategory.List();
        PitchJudgeCriteriaList = new PitchCriteriaVM
        {

            PitchCriteria = new QuestionUse(),
            Question = _unitOfWork.Question.Get(a => a.Id == 2),
            Category = _unitOfWork.QCategory.Get(c => c.QCategoryID == 4),
            QuestionDetailList = _unitOfWork.QuestionDetail.List(null, null, "Question"),
            QuestionList = _unitOfWork.Question.List(null, q => q.Id, null),
            QCategoryList = QCategories.Select(c => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Value = c.QCategoryID.ToString(), Text = c.QCategoryDesc })


            //        public QuestionUse? PitchCriteria { get; set; }
            //public Question? Question { get; set; }
            //public QCategory? Category { get; set; }

            //public IEnumerable<SelectListItem> QuestionDetailList { get; set; }
            //public IEnumerable<SelectListItem> QuestionList { get; set; }
            //public IEnumerable<SelectListItem> QCategoryList { get; set; }
        };

        //IEnumerable<QuestionUse> PitchJudgeCriteriaList = _unitOfWork.QuestionUse.List(u => u.QCategory.QCategoryID == 4, u => u.QuestionUseID, "Question,QCategory"); //_unitOfWork is the database, Applications is the table, GetAll puts rows in a list
        return View(PitchJudgeCriteriaList);
    }
}