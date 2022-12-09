﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Security.Claims;
using wildcatMicroFund.Areas.Mentor.ViewModels;
using wildcatMicroFund.Data;
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
        var claimsIdentity = (ClaimsIdentity)User.Identity;
        var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
           
        IEnumerable<ApplicationStatus> AdminReviewApplication = _unitOfWork.ApplicationStatus.List(a => a.Status.StatusDesc == "Mentor Phase", null, "Application,Status");//WHERE, ORDERBY, JOIN
        return View(AdminReviewApplication);
    }

    [HttpGet]
    public IActionResult Upsert(int? id, int? appId) //optional id needed with edit mode vs create
    {

        var stati = _unitOfWork.Status.List();
        var mentors = _unitOfWork.ApplicationUser.List(null, null, "AspNetRoles");

        ReviewApplicationObj = new ReviewApplicationVM
        {
            UserAssignment = new UserAssignment(),
            AssignedUsers = _unitOfWork.UserAssignment.List(u => u.Application.Id == appId, u => u.Application.Id, "Application,ApplicationUser,UserApplicationAssignmentType"),
            ReviewApplication = new ApplicationStatus(),
            Application = _unitOfWork.Application.Get(a => a.Id == appId),
            Status = _unitOfWork.Status.Get(s => s.StatusID == id),
            StatusList = stati.Select(f => new SelectListItem { Value = f.StatusID.ToString(), Text = f.StatusDesc }),
            MentorList = mentors.Select(m => new SelectListItem { Value = m.Id, Text = m.FullName})
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
        var claimsIdentity = (ClaimsIdentity)User.Identity;
        var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

        ReviewApplicationObj.ReviewApplication.StatusDate = DateTime.Now;
        ReviewApplicationObj.ReviewApplication.UserID = claim.Value;
        _unitOfWork.ApplicationStatus.Update(ReviewApplicationObj.ReviewApplication);

        _unitOfWork.Commit();
        return RedirectToAction("Index");
    }
}
