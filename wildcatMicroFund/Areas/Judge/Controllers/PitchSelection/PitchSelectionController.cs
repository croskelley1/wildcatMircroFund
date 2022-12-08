using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using wildcatMicroFund.Areas.Judge.ViewModels;
using wildcatMicroFund.Interfaces;
using wildcatMicroFund.Models;

[Area("Judge")]
public class PitchSelectionController : Controller
{

    private readonly IUnitOfWork _unitOfWork;


    public PitchSelectionController(IUnitOfWork unitOfWork)//Dependency Injection
    {
        _unitOfWork = unitOfWork;
    }

    public ViewResult PitchSelection()
    {
        //IEnumerable<QuestionUse> PitchJudgeCriteriaList = _unitOfWork.QuestionUse.List(u => u.QCategory.QCategoryID == 4, u => u.QuestionUseID, "Question,QCategory"); //_unitOfWork is the database, Applications is the table, GetAll puts rows in a list
        IEnumerable<ApplicationStatus> PitchSelectionList = _unitOfWork.ApplicationStatus.List(a => a.Status.StatusID == 6, null, "Application,Status");

        return View(PitchSelectionList);
    }
}


