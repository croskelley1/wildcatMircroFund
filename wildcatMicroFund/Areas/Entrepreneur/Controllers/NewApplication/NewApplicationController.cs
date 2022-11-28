using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.Diagnostics;
using System.Security.Claims;
using wildcatMicroFund.Interfaces;
using wildcatMicroFund.Models;

[Area("Entrepreneur")]
public class NewApplicationController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public NewApplicationController(IUnitOfWork unitOfWork)//Dependency Injection
    {
        _unitOfWork = unitOfWork;

    }

    public ViewResult Index()
    {
        var claimID = (ClaimsIdentity)User.Identity;
        var claim = claimID.FindFirst(ClaimTypes.NameIdentifier);
        
        IEnumerable<UserAssignment> appList = _unitOfWork.UserAssignment.List(a => a.User.Id == claim.Value);
        if (appList != null)
            return View(appList);
        else
            return View();
    }
    
    public ViewResult ApplicationForm()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Application obj)
    {

        if (ModelState.IsValid)
        {
            var claimID = (ClaimsIdentity)User.Identity;
            var claim = claimID.FindFirst(ClaimTypes.NameIdentifier);

            _unitOfWork.Application.Add(obj); //internal add

            var _UserAssignment = new UserAssignment();
            _UserAssignment.Application = _unitOfWork.Application.Get(a => a.CompanyName == obj.CompanyName && a.CreatedDate == obj.CreatedDate);
            _UserAssignment.User = _unitOfWork.ApplicationUser.Get(a => a.Id == claim.Value);
            _UserAssignment.ApplicationAssignmentType = _unitOfWork.UserApplicationAssignmentType.GetById(4);

            _unitOfWork.UserAssignment.Add(_UserAssignment); 

            _unitOfWork.Commit(); //physical commit to DB table
            TempData["success"] = "Application created Successfully";
            return RedirectToAction("Index");
        }
        return View(obj);
    }
}