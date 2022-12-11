using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using wildcatMicroFund.Areas.Judge.ViewModels;
using wildcatMicroFund.Interfaces;
using wildcatMicroFund.Models;

[Area("Judge")]
public class PitchCriteriaController : Controller
{
    private readonly IEmailSender _emailSender;
    private readonly IUnitOfWork _unitOfWork;
    public PitchCriteriaVM PitchJudgeCriteriaList { get; set; }
    public ScoredAppVM ScoredAppVM { get; set; }

    public PitchCriteriaController(IUnitOfWork unitOfWork, IEmailSender emailSender)//Dependency Injection
    {
        _emailSender = emailSender;
        _unitOfWork = unitOfWork;
    }

    public ViewResult ScoredApp(int AppID)
    {
        ScoredAppVM = new ScoredAppVM
        {
            appID = AppID,
            Application = _unitOfWork.Application.GetById(AppID),
            AssignedQuestions = _unitOfWork.AssignedQuestion.List(a => a.Application.Id == AppID, null, "QuestionUse,Application"),
            Score = _unitOfWork.Score.List(),
            QuestionUseList = _unitOfWork.QuestionUse.List(u => u.QCategory.QCategoryID == 4, u => u.QuestDisplayOrder, "Question,QCategory"),
            QuestionDetailList = _unitOfWork.QuestionDetail.List(null, null, "Question")

        };

        return View(ScoredAppVM);
    }

    [HttpGet]
    public IActionResult PitchCriteria(int AppID) // Capture the passed ID
    {
        //IEnumerable<QuestionUse> PitchJudgeCriteriaList = _unitOfWork.QuestionUse.List(u => u.QCategory.QCategoryID == 4, u => u.QuestionUseID, "Question,QCategory"); //_unitOfWork is the database, Applications is the table, GetAll puts rows in a list
        //return View(PitchJudgeCriteriaList);
        var qdList = _unitOfWork.QuestionDetail.List(null, null, "Question");
        var questions = _unitOfWork.Question.List();
        var QCategories = _unitOfWork.QCategory.List();

        PitchJudgeCriteriaList = new PitchCriteriaVM
        {
            appID = AppID,
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

    [HttpPost]
    public IActionResult PitchCriteria(int Quest_1, int Quest_2, int Quest_3, int Quest_4, int Quest_5, int qu_1, int qu_2, int qu_3, int qu_4, int qu_5, int appID)
    {
        // hardcoded Assigned question stuff
        // DON'T JUDGE US...
        var assignedQuestion1 = new AssignedQuestion();
        var assignedQuestion2 = new AssignedQuestion();
        var assignedQuestion3 = new AssignedQuestion();
        var assignedQuestion4 = new AssignedQuestion();
        var assignedQuestion5 = new AssignedQuestion();

        var questionUse = new QuestionUse();
        var app = new Application();
        app = _unitOfWork.Application.GetById(appID);

        questionUse = _unitOfWork.QuestionUse.Get(a => a.QuestionUseID == qu_1);
        assignedQuestion1.QuestionUse = questionUse;
        assignedQuestion1.AppQuestionDate = DateTime.Now;
        assignedQuestion1.Application = app;

        _unitOfWork.AssignedQuestion.Add(assignedQuestion1);


        questionUse = _unitOfWork.QuestionUse.Get(a => a.QuestionUseID == qu_2);
        assignedQuestion2.QuestionUse = questionUse;
        assignedQuestion2.AppQuestionDate = DateTime.Now;
        assignedQuestion2.Application = app;

        _unitOfWork.AssignedQuestion.Add(assignedQuestion2);


        questionUse = _unitOfWork.QuestionUse.Get(a => a.QuestionUseID == qu_3);
        assignedQuestion3.QuestionUse = questionUse;
        assignedQuestion3.AppQuestionDate = DateTime.Now;
        assignedQuestion3.Application = app;

        _unitOfWork.AssignedQuestion.Add(assignedQuestion3);


        questionUse = _unitOfWork.QuestionUse.Get(a => a.QuestionUseID == qu_4);
        assignedQuestion4.QuestionUse = questionUse;
        assignedQuestion4.AppQuestionDate = DateTime.Now;
        assignedQuestion4.Application = app;

        _unitOfWork.AssignedQuestion.Add(assignedQuestion4);


        questionUse = _unitOfWork.QuestionUse.Get(a => a.QuestionUseID == qu_5);
        assignedQuestion5.QuestionUse = questionUse;
        assignedQuestion5.AppQuestionDate = DateTime.Now;
        assignedQuestion5.Application = app;

        _unitOfWork.AssignedQuestion.Add(assignedQuestion5);

        _unitOfWork.Commit();

        // hardcoded 
        assignedQuestion1 = _unitOfWork.AssignedQuestion.Get(a => a.QuestionUse.QuestionUseID == qu_1 && a.AppQuestionDate == assignedQuestion1.AppQuestionDate && a.Application.Id == appID);
        assignedQuestion2 = _unitOfWork.AssignedQuestion.Get(a => a.QuestionUse.QuestionUseID == qu_2 && a.AppQuestionDate == assignedQuestion2.AppQuestionDate && a.Application.Id == appID);
        assignedQuestion3 = _unitOfWork.AssignedQuestion.Get(a => a.QuestionUse.QuestionUseID == qu_3 && a.AppQuestionDate == assignedQuestion3.AppQuestionDate && a.Application.Id == appID);
        assignedQuestion4 = _unitOfWork.AssignedQuestion.Get(a => a.QuestionUse.QuestionUseID == qu_4 && a.AppQuestionDate == assignedQuestion4.AppQuestionDate && a.Application.Id == appID);
        assignedQuestion5 = _unitOfWork.AssignedQuestion.Get(a => a.QuestionUse.QuestionUseID == qu_5 && a.AppQuestionDate == assignedQuestion5.AppQuestionDate && a.Application.Id == appID);

        var score1 = new Score();
        var score2 = new Score();
        var score3 = new Score();
        var score4 = new Score();
        var score5 = new Score();

        var claimsIdentity = (ClaimsIdentity)User.Identity;
        var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

        score1.UserID = claim.Value;
        score1.ScoreValue = Quest_1;
        score1.AssignedQuestion = assignedQuestion1;
        _unitOfWork.Score.Add(score1);

        score2.UserID = claim.Value;
        score2.ScoreValue = Quest_2;
        score2.AssignedQuestion = assignedQuestion2;
        _unitOfWork.Score.Add(score2);

        score3.UserID = claim.Value;
        score3.ScoreValue = Quest_3;
        score3.AssignedQuestion = assignedQuestion3;
        _unitOfWork.Score.Add(score3);

        score4.UserID = claim.Value;
        score4.ScoreValue = Quest_4;
        score4.AssignedQuestion = assignedQuestion4;
        _unitOfWork.Score.Add(score4);

        score5.UserID = claim.Value;
        score5.ScoreValue = Quest_5;
        score5.AssignedQuestion = assignedQuestion5;
        _unitOfWork.Score.Add(score5);

        _unitOfWork.Commit();

        var routeValues = new RouteValueDictionary {
          { "AppID", appID}
        };

        _emailSender.SendEmailAsync("wildcatmicrofund@yahoo.com", "Application Judged", "An application for " + app.CompanyName + " has been Judged. Sorry we don't have a link.  :D ");

        return RedirectToAction("ScoredApp", routeValues);
    }
}


