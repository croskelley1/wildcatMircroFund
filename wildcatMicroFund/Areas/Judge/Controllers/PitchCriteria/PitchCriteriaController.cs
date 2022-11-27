using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using wildcatMicroFund.Areas.Judge.ViewModels;
using wildcatMicroFund.Interfaces;
using wildcatMicroFund.Models;

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
        //IEnumerable<QuestionUse> PitchJudgeCriteriaList = _unitOfWork.QuestionUse.List(u => u.QCategory.QCategoryID == 4, u => u.QuestionUseID, "Question,QCategory"); //_unitOfWork is the database, Applications is the table, GetAll puts rows in a list
        //return View(PitchJudgeCriteriaList);
        var qdList = _unitOfWork.QuestionDetail.List(null, null, "Question");
        var questions = _unitOfWork.Question.List();
        var QCategories = _unitOfWork.QCategory.List();

        PitchJudgeCriteriaList = new PitchCriteriaVM
        {
            PitchCriteria = new QuestionUse(),
            Question = _unitOfWork.Question.Get(a => a.Id == 2),
            Category = _unitOfWork.QCategory.Get(c => c.QCategoryID == 4),
            QuestionDetailList = _unitOfWork.QuestionDetail.List(null, null, "Question"),
            QuestionList = _unitOfWork.Question.List(null, q => q.Id, null),//This needs to filter on QCategory == 4
            QCategoryList = QCategories.Select(c => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Value = c.QCategoryID.ToString(), Text = c.QCategoryDesc }),
            QuestionUseList = _unitOfWork.QuestionUse.List(u => u.QCategory.QCategoryID == 4, u => u.QuestDisplayOrder, "Question,QCategory")
        };

        return View(PitchJudgeCriteriaList);
    }
}


