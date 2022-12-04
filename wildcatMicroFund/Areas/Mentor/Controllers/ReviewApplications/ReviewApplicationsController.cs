using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;
using wildcatMicroFund.Areas.Mentor.ViewModels;
using wildcatMicroFund.Interfaces;
using wildcatMicroFund.Models;

[Area("Mentor")]
public class ReviewApplicationsController : Controller
{
    [BindProperty]
    public ReviewApplicationVM ReviewApplicationObj { get; set; }

    private readonly IUnitOfWork _unitOfWork;
    private readonly IWebHostEnvironment _hostEnvironment;
    public ReviewApplicationsController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)//Dependency Injection & path to wwwroot folder
    {
        _unitOfWork = unitOfWork;
        _hostEnvironment = hostEnvironment;
    }


    public ViewResult Index()
    {
        
        
        IEnumerable<ApplicationStatus> ReviewApplication = _unitOfWork.ApplicationStatus.List(null, r => r.Application.Id, "Application,Status");//WHERE, ORDERBY, JOIN
        return View(ReviewApplication);
    }

    public ViewResult MentorIndex()
    {
        
        ReviewApplicationObj = new ReviewApplicationVM
        {
            ApplicationStatuses = _unitOfWork.ApplicationStatus.List(null, r => r.Application.Id, "Application,Status"),//WHERE, ORDERBY, JOIN
            AssignedUsers = _unitOfWork.UserAssignment.List(u => u.UserApplicationAssignmentType.UserApplicationAssignmentTypeId == 4, null, "Application,ApplicationUser,UserApplicationAssignmentType")

        };
        return View(ReviewApplicationObj);
        
    }

    [HttpGet]
    public IActionResult Upsert(int? id, int? appId, int? statId) //optional id needed with edit mode vs create
    {
        
        var stati = _unitOfWork.Status.List();
        var mentorList = _unitOfWork.ApplicationUser.List();
        var judgeList = _unitOfWork.ApplicationUser.List();
        //var test = _unitOfWork.UserAssignment.GetAll(u => u.Application.Id == appId, includeProperties: "IdentityUser");
        var assUsers = _unitOfWork.UserAssignment.List(u => u.Application.Id == appId, u => u.Application.Id, "Application,ApplicationUser,UserApplicationAssignmentType");


        var appStatus = new ApplicationStatus();
        var app = _unitOfWork.Application.Get(a => a.Id == appId);
        var status = _unitOfWork.Status.Get(s => s.StatusID == statId);
        

        ReviewApplicationObj = new ReviewApplicationVM
        {
            
            UserAssignment = new UserAssignment(),
            AssignedUsers = assUsers,
            ApplicationStatus = appStatus,
            Application = app,
            Status = _unitOfWork.Status.Get(s => s.StatusID == statId),
            StatusList = stati.Select(f => new SelectListItem { Value = f.StatusID.ToString(), Text = f.StatusDesc }),
            MentorList = mentorList.Select(m => new SelectListItem { Value = m.Id.ToString(), Text=m.FullName.ToString() })

            
        };

        if (id != null)
        {
            //ReviewApplicationObj.Entrepreneur = _unitOfWork.ApplicationUser.Get(u => u. == id, true);
            if (ReviewApplicationObj == null)
            {
                return NotFound();
            }
        }

        return View(ReviewApplicationObj);
    }

    [HttpPost]
    public IActionResult Upsert()
    {
        
        if (!ModelState.IsValid)
        {
            return View();
        }

                                        
        _unitOfWork.UserAssignment.Update(ReviewApplicationObj.UserAssignment);
        
        _unitOfWork.Commit();
        return RedirectToAction("Index");
    }
}
