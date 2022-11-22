using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using wildcatMicroFund.Areas.Admin.ViewModels;
// using wildcatMicroFund.Areas.Mentor.ViewModels;
using wildcatMicroFund.Interfaces;
using wildcatMicroFund.Models;

[Area("Admin")]
public class AdminReviewApplicationsController : Controller
{
    [BindProperty]
    public AdminReviewApplicationVM AdminReviewApplicationObj { get; set; }

    private readonly IUnitOfWork _unitOfWork;
    private readonly IWebHostEnvironment _hostEnvironment;
    public AdminReviewApplicationsController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)//Dependency Injection & path to wwwroot folder
    {
        _unitOfWork = unitOfWork;
        _hostEnvironment = hostEnvironment;
    }


    public ViewResult Index()
    {
        IEnumerable<AdminReviewApplication> AdminReviewApplication = _unitOfWork.AdminReviewApplication.List(null, null, "Application,Status");//WHERE, ORDERBY, JOIN
        return View(AdminReviewApplication);
    }

    [HttpGet]
    public IActionResult Upsert(int? id) //optional id needed with edit mode vs create
    {
        var categories = _unitOfWork.Application.List();
        var statui = _unitOfWork.Status.List();

        AdminReviewApplicationObj = new AdminReviewApplicationVM
        {
            AdminReviewApplication = new AdminReviewApplication(),
            ApplicationList = categories.Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.CompanyName }),
            StatusList = statui.Select(f => new SelectListItem { Value = f.StatusID.ToString(), Text = f.StatusDesc })
        };

        if (id != null)
        {
            AdminReviewApplicationObj.AdminReviewApplication = _unitOfWork.AdminReviewApplication.Get(u => u.Id == id, true);
            if (AdminReviewApplicationObj == null)
            {
                return NotFound();
            }
        }

        return View(AdminReviewApplicationObj);
    }
}
