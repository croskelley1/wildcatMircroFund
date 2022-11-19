using Microsoft.AspNetCore.Mvc;
using wildcatMicroFund.Interfaces;
using wildcatMicroFund.Models;

[Area("Judge")]
public class PitchCriteriaController : Controller
{

    private readonly IUnitOfWork _unitOfWork;

    public PitchCriteriaController(IUnitOfWork unitOfWork)//Dependency Injection
    {
        _unitOfWork = unitOfWork;
    }

    public ViewResult PitchCriteria()
    {
        IEnumerable<QuestionUse> PitchJudgeCriteriaList = _unitOfWork.QuestionUse.List(u => u.QCategory.QCategoryID == 4, u => u.QuestionUseID, "Question,QCategory"); //_unitOfWork is the database, Applications is the table, GetAll puts rows in a list
        return View(PitchJudgeCriteriaList);
    }
}

