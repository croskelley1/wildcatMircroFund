using Microsoft.AspNetCore.Mvc;
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
        
        var appList = _unitOfWork.UserAssignment.List(a => a.User.Id == claim.Value, a => a.UserAssignmentID, "Application");
        return View(appList);

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
            // User data
            var claimID = (ClaimsIdentity)User.Identity;
            var claim = claimID.FindFirst(ClaimTypes.NameIdentifier);

            obj.AppStatus = _unitOfWork.Status.Get(a => a.StatusID == 1).StatusID;  // sets the Application Status as 'submitted'
            
            _unitOfWork.Application.Add(obj); //internal add

            // New UserAssignment entry created to tie Application and User
            var _UserAssignment = new UserAssignment();
            _UserAssignment.Application = _unitOfWork.Application.Get(a => a.CompanyName == obj.CompanyName && a.CreatedDate == obj.CreatedDate); // Get ApplicationID from application table
            _UserAssignment.User = _unitOfWork.ApplicationUser.Get(a => a.Id == claim.Value);   // Get User object from users table
            _UserAssignment.ApplicationAssignmentType = _unitOfWork.UserApplicationAssignmentType.GetById(4);   // Set App assignment type to Entrepreneur

            _unitOfWork.UserAssignment.Add(_UserAssignment); // internal add

            // Inserting new entry into ApplicationStatus table
            var _AppStatus = new ApplicationStatus();
            _AppStatus.UserID = claim.Value;    // This takes just a userID instead of a user object, so claim.Value is just used here
            _AppStatus.ApplicationId = _UserAssignment.Application.Id;   // Pull Application ID from _UserAssignment since already queried
            _AppStatus.StatusId = obj.AppStatus;    // Already pulled statusID for obj...
            _AppStatus.StatusDate = DateTime.Now;   // pretty self explanitory...

            _unitOfWork.ApplicationStatus.Add(_AppStatus);


            _unitOfWork.Commit(); //physical commit to DB table
            TempData["success"] = "Application created Successfully";
            return RedirectToAction("Index");
        }
        return View(obj);
    }
}