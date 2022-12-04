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


            IEnumerable<Note> MentorNoteObj = _unitOfWork.Note.List(a => a.Application.Id == appId,a=>a.NoteID, "Application,NoteType");//WHERE, ORDERBY, JOIN
            return View(MentorNoteObj);
        }
    }

