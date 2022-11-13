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
        IEnumerable<ReviewApplication> ReviewApplication = _unitOfWork.ReviewApplication.List(null, null, "Application,Status");//WHERE, ORDERBY, JOIN
        return View(ReviewApplication);
    }

    [HttpGet]
    public IActionResult Upsert(int? id) //optional id needed with edit mode vs create
    {
        var categories = _unitOfWork.Application.List();
        var statui = _unitOfWork.Status.List();

        ReviewApplicationObj = new ReviewApplicationVM
        {
            ReviewApplication = new ReviewApplication(),
            ApplicationList = categories.Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.CompanyName }),
            StatusList = statui.Select(f => new SelectListItem { Value = f.Id.ToString(), Text = f.Name })
        };

        if (id != null)
        {
            ReviewApplicationObj.ReviewApplication = _unitOfWork.ReviewApplication.Get(u => u.Id == id, true);
            if (ReviewApplicationObj == null)
            {
                return NotFound();
            }
        }

        return View(ReviewApplicationObj);
    }
}