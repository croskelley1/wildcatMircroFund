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
        
        IEnumerable<ApplicationStatus> ReviewApplication = _unitOfWork.ApplicationStatus.List(r => r.Status.StatusID == 2 || r.Status.StatusID == 5, r => r.Application.Id, "Application,Status");//WHERE, ORDERBY, JOIN
        return View(ReviewApplication);
    }

    [HttpGet]
    public IActionResult Upsert(int? id, int? appId, int? statId) //optional id needed with edit mode vs create
    {
        
        var stati = _unitOfWork.Status.List();
        var mentorList = _unitOfWork.ApplicationUser.List();
        var judgeList = _unitOfWork.ApplicationUser.List();

        var ent = _unitOfWork.UserAssignment.Get(e => e.ApplicationAssignmentType.UserApplicationAssignmentDesc == "Entrepreneur" && e.Application.Id == appId);
        var mentor = _unitOfWork.UserAssignment.Get(m => m.ApplicationAssignmentType.UserApplicationAssignmentDesc == "Mentor" && m.Application.Id == appId);
        //var judge = _unitOfWork.UserAssignment.Get(j => j.ApplicationAssignmentType.UserApplicationAssignmentDesc == "Judge" && j.Application.Id == appId);
        var appStatus = new ApplicationStatus();
        var app = _unitOfWork.Application.Get(a => a.Id == appId);
        var status = _unitOfWork.Status.Get(s => s.StatusID == statId);
        //var userAssignment = _unitOfWork.UserApplicationAssignmentType.Get(u => u.UserApplicationAssignmentTypeId == ent.ApplicationAssignmentType.UserApplicationAssignmentTypeId);

        ReviewApplicationObj = new ReviewApplicationVM
        {
            
            UserAssignment = new UserAssignment(),
            Entrepreneur = _unitOfWork.ApplicationUser.Get(e => e.Id == ent.User.Id),
            Mentor = (mentor.UserAssignmentID == null ? null : _unitOfWork.ApplicationUser.Get(m=> m.Id == mentor.User.Id)),
            //Judge = judge,
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
