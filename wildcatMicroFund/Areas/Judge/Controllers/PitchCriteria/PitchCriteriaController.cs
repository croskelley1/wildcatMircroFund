using Microsoft.AspNetCore.Mvc;
using wildcatMicroFund.Interfaces;
using wildcatMicroFund.Models;

public class PitchCriteriaController : Controller
{

    private readonly IUnitOfWork _unitOfWork;

    public PitchCriteriaController(IUnitOfWork unitOfWork)//Dependency Injection
    {
        _unitOfWork = unitOfWork;
    }

    public ViewResult Index()
    {
        IEnumerable<Question> objQuestionList = _unitOfWork.Question.GetAll(); //_unitOfWork is the database, Applications is the table, GetAll puts rows in a list
        return View(objQuestionList);
    }
}

