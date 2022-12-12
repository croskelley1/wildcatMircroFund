using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using System.Collections;
using wildcatMicroFund.Areas.Admin.ViewModels;
using wildcatMicroFund.Areas.Entrepreneur.ViewModels;
using wildcatMicroFund.Data;
using wildcatMicroFund.Interfaces;
using wildcatMicroFund.Models;
using wildcatMicroFund.Utilities;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Data.SqlClient;
using System.Data;
using wildcatMicroFund.Areas.Entrepreneur;
using NuGet.Protocol;

[Area("Entrepreneur")]
public class NewApplicationController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IEmailSender _emailSender;
    public AppStatusVM AppStatusVM { get; set; }
    public ApplicationFormVM AppFormVM { get; set; }
    public NewApplicationController(IUnitOfWork unitOfWork, IEmailSender emailSender)//Dependency Injection
    {
        _unitOfWork = unitOfWork;
        _emailSender = emailSender;
    }

    public ViewResult Index()
    {
        var claimID = (ClaimsIdentity)User.Identity;
        var claim = claimID.FindFirst(ClaimTypes.NameIdentifier);

        // var appList = _unitOfWork.UserAssignment.List(a => a.ApplicationUser.Id == claim.Value, a => a.UserAssignmentID, "Application");
        AppStatusVM = new AppStatusVM
        {
            userAssignments = _unitOfWork.UserAssignment.List(a => a.ApplicationUser.Id == claim.Value, a => a.UserAssignmentID, "Application"),
            status = _unitOfWork.Status.List(null, null, null)
        };
        return View(AppStatusVM);
    }

    public ViewResult ApplicationForm()
    {
        List<Question> questions = DataHandling.GetQuestions();
        List<Response> responses = new List<Response>();
        
        ApplicationFormVM AppForm = new ApplicationFormVM
        {
            Questions = questions,
            rawResponses = new string[questions.Count],
            Responses = responses
        };

        return View(AppForm);
    }

    /// <summary>
    /// Creates new entries in the database tables for Application, User Assignments, and App Status. 
    /// Also stores user answered questions from the form in a, for now, unknown table. 
    /// </summary>
    /// <param name="obj">ApplicationFormVM object</param>
    /// <returns></returns>
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(ApplicationFormVM obj)
    {
        if (ModelState.IsValid)
        {
            ApplicationFormVM asdf = obj;
            asdf.Questions = DataHandling.GetQuestions();
            // User data
            var claimID = (ClaimsIdentity)User.Identity; 
            var claim = claimID.FindFirst(ClaimTypes.NameIdentifier);

            obj.Application.AppStatus = _unitOfWork.Status.Get(a => a.StatusID == 1).StatusID;  // sets the Application Status as 'submitted'
            obj.Application.CreatedDate = DateTime.Now;            

            _unitOfWork.Application.Add(obj.Application); //internal add

            // New UserAssignment entry created to tie Application and User
            var _UserAssignment = new UserAssignment();
            _UserAssignment.Application = _unitOfWork.Application.Get(a => a.CompanyName == obj.Application.CompanyName && a.CreatedDate == obj.Application.CreatedDate); // Get ApplicationID from application table
            _UserAssignment.ApplicationUser = _unitOfWork.ApplicationUser.Get(a => a.Id == claim.Value);   // Get User object from users table
            _UserAssignment.UserApplicationAssignmentType = _unitOfWork.UserApplicationAssignmentType.GetById(4);   // Set App assignment type to Entrepreneur

            _unitOfWork.UserAssignment.Add(_UserAssignment); // internal add

            // Inserting new entry into ApplicationStatus table
            var _AppStatus = new ApplicationStatus();
            _AppStatus.UserID = claim.Value;    // This takes just a userID instead of a user object, so claim.Value is just used here
            _AppStatus.ApplicationId = _UserAssignment.Application.Id;   // Pull Application ID from _UserAssignment since already queried
            _AppStatus.StatusId = obj.Application.AppStatus;    // Already pulled statusID for obj...
            _AppStatus.StatusDate = DateTime.Now;   // pretty self explanitory...

            _unitOfWork.ApplicationStatus.Add(_AppStatus);

            List<Response> temp_responses = new List<Response>();
            // Inserting user responses to questions
            for(int i = 0; i < obj.rawResponses.Count(); i++)
            {
                Response temp = new Response();
                temp.QuestionID = asdf.Questions[i].Id;
                temp.Responses = obj.rawResponses[i];

                temp_responses.Add(temp);
            }

            foreach (var r in temp_responses)
            {
                _unitOfWork.Response.Add(r);
            }

            _unitOfWork.Commit(); //physical commit to DB table
            TempData["success"] = "Application created Successfully";

            // Send an email
            _emailSender.SendEmailAsync("wildcatmicrofund@yahoo.com", "New Application Submitted", "A new application for " + obj.Application.CompanyName + " has been submitted.\nReview applications here:\nhttp://wildcatmicrofund-001-site1.gtempurl.com/Admin/AdminReviewApplications");
            return RedirectToAction("Index");
        }
        return View(obj);
    }
}