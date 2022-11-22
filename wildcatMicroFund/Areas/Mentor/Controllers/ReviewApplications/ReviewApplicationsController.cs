using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        ReviewApplicationObj = new ReviewApplicationVM
        {
            ReviewApplication = new ApplicationStatus(),
            Application = _unitOfWork.Application.Get(a => a.Id == appId),
            Status = _unitOfWork.Status.Get(s => s.StatusID == statId),
            StatusList = stati.Select(f => new SelectListItem { Value = f.StatusID.ToString(), Text = f.StatusDesc })
        };

        if (id != null)
        {
            ReviewApplicationObj.ReviewApplication = _unitOfWork.ApplicationStatus.Get(u => u.AppStatId == id, true);
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

                                        
        _unitOfWork.ApplicationStatus.Update(ReviewApplicationObj.ReviewApplication);
        
        _unitOfWork.Commit();
        return RedirectToAction("Index");
    }
}
