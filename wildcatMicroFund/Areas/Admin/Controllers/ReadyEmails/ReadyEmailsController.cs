
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Dynamic;
using System.Linq;
using wildcatMicroFund.Areas.Admin.ViewModels;
using wildcatMicroFund.Interfaces;
using wildcatMicroFund.Models;

[Area("Admin")]
public class ReadyEmailsController : Controller
{
    private readonly IEmailSender _emailSender;
    private readonly IUnitOfWork _unitOfWork;
    public ReadyEmailsController(IUnitOfWork unitOfWork, IEmailSender emailSender) 
    {
        _unitOfWork = unitOfWork;
        _emailSender = emailSender;
    }
    public UserEmailVM UserEmailObj { get; set; }
    public ViewResult Index()
    {
        IEnumerable<ReadyEmail> objReadyEmail = _unitOfWork.ReadyEmail.GetAll();
        IEnumerable<UserEmailVM> viewObj;
        List<UserEmailVM> viewList = new List<UserEmailVM>();
        foreach (ReadyEmail email in objReadyEmail) 
        {
            UserEmailObj = new UserEmailVM
            {
                ReadyEmail = email,
                User = _unitOfWork.ApplicationUser.Get(c => c.Id == email.UserID),
                EmailTemplate = _unitOfWork.EmailTemplate.Get(c => c.Id == email.EmailTemplateId)


            };
            System.Diagnostics.Debug.WriteLine("Email Template Name: "+UserEmailObj.EmailTemplate.EmailTemplateName);
            viewList.Add(UserEmailObj);
        }
        viewObj = viewList;
        return View(viewObj);
    }
    [HttpGet]
    public IActionResult Create() 
    {
        ViewBag.Users=GetUsers();
        ViewBag.EmailTemplates = GetEmailTemplates();
        return View();
    }
    [HttpPost]
    public IActionResult Create(ReadyEmail readyEmail) 
    {
        readyEmail.EmailTemplate = _unitOfWork.EmailTemplate.Get(c => c.Id == readyEmail.EmailTemplateId);
        readyEmail.User = _unitOfWork.ApplicationUser.Get(c => c.Id == readyEmail.UserID);
        if (readyEmail.User != null && readyEmail.EmailTemplate != null)
        {
            readyEmail.CreatedDate = DateTime.Now;
            readyEmail.ReadyEmailContent = _unitOfWork.ReadyEmail.InitializeEmail(readyEmail);
            readyEmail.ReadyEmailSubject = readyEmail.EmailTemplate.TemplateSubject;
            readyEmail.ReadyEmailEmail = readyEmail.User.Email;
            _unitOfWork.ReadyEmail.Add(readyEmail);
            _unitOfWork.Commit();
            TempData["success"] = "Email created Successfully";
            return RedirectToAction("Index");
        }
        return View(readyEmail);
    }
    [HttpGet]
    public IActionResult Edit(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }
        var readyEmail = _unitOfWork.ReadyEmail.Get(c => c.Id == id);
        if (readyEmail == null)
        {
            return NotFound();
        }
        return View(readyEmail);
    }
    [HttpGet]
    public IActionResult Delete(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }
        var readyEmailFromDb = _unitOfWork.ReadyEmail.Get(c => c.Id == id);
        if (readyEmailFromDb == null)
        {
            return NotFound();
        }
        return View(readyEmailFromDb);
    }
    [HttpGet]
    public async Task<IActionResult> Send(int? id)
    {
        //Currently Just deletes when sent
        var obj = _unitOfWork.ReadyEmail.Get(c => c.Id == id);
        if (obj == null)
        {
            return NotFound();
        }
        await _emailSender.SendEmailAsync(obj.ReadyEmailEmail, obj.ReadyEmailSubject, obj.ReadyEmailContent);
        _unitOfWork.ReadyEmail.Delete(obj);
        _unitOfWork.Commit();
        TempData["success"] = "ReadyEmail was deleted Successfully";
        return RedirectToAction("Index");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(ReadyEmail obj)
    {
        obj.CreatedDate = DateTime.Now;
        obj.User = _unitOfWork.ApplicationUser.Get(c => c.Id == obj.UserID);
        obj.EmailTemplate = _unitOfWork.EmailTemplate.Get(c => c.Id == obj.EmailTemplateId);
        //if (ModelState.IsValid)
        //{
        if (obj != null)
        {
            if (obj.EmailTemplate != null && obj.User != null)
            {
                if (obj.ReadyEmailContent != null && !obj.ReadyEmailContent.Equals(String.Empty))
                {
                    if (obj.ReadyEmailEmail != null && !obj.ReadyEmailEmail.Equals(String.Empty))
                    {
                        if (obj.ReadyEmailSubject != null && !obj.ReadyEmailSubject.Equals(String.Empty))
                        {
                            _unitOfWork.ReadyEmail.Update(obj);
                            _unitOfWork.Commit();
                            TempData["success"] = "Email Template updated Successfully";
                            return RedirectToAction("Index");
                            //}
                        }
                    }
                }
            }
        }

        return View(obj);
    }
    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePost(int? id)
    {
        var obj = _unitOfWork.ReadyEmail.Get(c => c.Id == id);
        if (obj == null)
        {
            return NotFound();
        }
        _unitOfWork.ReadyEmail.Delete(obj);
        _unitOfWork.Commit();
        TempData["success"] = "ReadyEmail was deleted Successfully";
        return RedirectToAction("Index");
    }

    private List<SelectListItem> GetUsers() 
    {
        var lstUsers = new List<SelectListItem>();
        IEnumerable<ApplicationUser> users = _unitOfWork.ApplicationUser.GetAll();
        lstUsers = users.Select(u => new SelectListItem() 
        {
            Value = u.Id,
            Text = u.FullName
        }).ToList();
        var defItem = new SelectListItem()
        {
            Value="",
            Text ="----Select User----"
        };
        lstUsers.Insert(0, defItem);
        return lstUsers;
    }
    private List<SelectListItem> GetEmailTemplates()
    {
        var lstTemplates = new List<SelectListItem>();
        IEnumerable<EmailTemplate> templates = _unitOfWork.EmailTemplate.GetAll();
        lstTemplates = templates.Select(u => new SelectListItem()
        {
            Value = u.Id.ToString(),
            Text = u.EmailTemplateName
        }).ToList();
        var defItem = new SelectListItem()
        {
            Value = "",
            Text = "----Select Template----"
        };
        lstTemplates.Insert(0, defItem);
        return lstTemplates;
    }
}

