using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;
using wildcatMicroFund.Areas.Mentor.ViewModels;
using wildcatMicroFund.Interfaces;
using wildcatMicroFund.Models;

[Area("Mentor")]

public class MentorNotesController : Controller
{
    [BindProperty]
    public MentorNoteVM MentorNoteObj { get; set; }

    private readonly IUnitOfWork _unitOfWork;
    private readonly IWebHostEnvironment _hostEnvironment;
    public MentorNotesController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)//Dependency Injection & path to wwwroot folder
    {
        _unitOfWork = unitOfWork;
        _hostEnvironment = hostEnvironment;
    }


    public IActionResult Index(int appId)
    {
        TempData["tempAppId"] = appId;
        IEnumerable<Note> MentorNoteObj = _unitOfWork.Note.List(a => a.Application.Id == appId, a => a.NoteID, "Application,NoteType");//WHERE, ORDERBY, JOIN
        return View(MentorNoteObj);
    }

    [HttpGet]
    public ViewResult Create(int appId)
    {
        TempData["tempAppId"] = appId;
        return View();
    }

    [HttpPost]
    public IActionResult Create(Note obj)
    {
        var claimsIdentity = (ClaimsIdentity)User.Identity;
        var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

        obj.Application = _unitOfWork.Application.Get(a => a.Id == obj.Application.Id);
        obj.NoteType = _unitOfWork.NoteType.Get(n => n.NoteTypeID == 1);
        obj.NoteCreatorUserId = claim.Value;
        obj.CreatedDate = DateTime.Now;
        
        
            
        _unitOfWork.Note.Add(obj); 
        _unitOfWork.Commit();
        TempData["success"] = "Note created successfully";
        return RedirectToAction("Index", new { appId = obj.Application.Id});      
     
    }

    [HttpGet]
    public IActionResult Edit(int? noteId)
    {
        if (noteId == null || noteId == 0)
            return NotFound();

        //grab that Category from the DB itself

        var noteRecord = _unitOfWork.Note.Get(n => n.NoteID == noteId, false, "Application,NoteType");

        if (noteRecord == null)
        {
            return NotFound();
        }

        return View(noteRecord);
    }

    [HttpPost]
    
    public IActionResult Edit(Note obj)
    {
        var claimsIdentity = (ClaimsIdentity)User.Identity;
        var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                
        obj.NoteCreatorUserId = claim.Value;
        obj.CreatedDate = DateTime.Now;

        _unitOfWork.Note.Update(obj);
        _unitOfWork.Commit();
        TempData["success"] = "Note updated Successfully";
        return RedirectToAction("Index", new { appId = obj.Application.Id });
    }
}