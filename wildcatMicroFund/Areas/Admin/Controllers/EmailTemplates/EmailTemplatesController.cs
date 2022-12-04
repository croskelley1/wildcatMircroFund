using Microsoft.AspNetCore.Mvc;
using wildcatMicroFund.Interfaces;
using wildcatMicroFund.Models;

[Area("Admin")]
public class EmailTemplatesController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    public EmailTemplatesController(IUnitOfWork unitOfWork) 
    {
        _unitOfWork = unitOfWork;
    }
    public ViewResult Index() 
    {
        IEnumerable<EmailTemplate> objEmailTemplateList = _unitOfWork.EmailTemplate.GetAll();
        return View(objEmailTemplateList);
    }
    [HttpGet]
    public ViewResult Create() 
    {
        return View();
    }
    [HttpGet]
    public IActionResult Edit(int? id) 
    {
        if (id == null || id == 0) 
        {
            return NotFound();
        }
        var emailTemplateFromDb = _unitOfWork.EmailTemplate.Get(c => c.Id == id);
        if (emailTemplateFromDb == null) 
        {
            return NotFound();
        }
        return View(emailTemplateFromDb);
    }
    [HttpGet]
    public IActionResult Delete(int? id) 
    {
        if (id == null || id == 0) 
        {
            return NotFound();
        }
        var emailTemplateFromDb = _unitOfWork.EmailTemplate.Get(c => c.Id == id);
        if (emailTemplateFromDb == null) 
        {
            return NotFound();
        }
        return View(emailTemplateFromDb);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(EmailTemplate obj) 
    {
        if (ModelState.IsValid) 
        {
            obj.ModifiedDate = DateTime.Now;
            _unitOfWork.EmailTemplate.Add(obj);
            _unitOfWork.Commit();
            TempData["success"] = "Email Template created Successfully";
            return RedirectToAction("Index");
        }
        return View(obj);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(EmailTemplate obj) 
    {
        if (ModelState.IsValid) 
        {
            obj.ModifiedDate = DateTime.Now;
            _unitOfWork.EmailTemplate.Update(obj);
            _unitOfWork.Commit();
            TempData["success"] = "Email Template updated Successfully";
            return RedirectToAction("Index");
        }
        return View(obj);
    }
    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePost(int? id) 
    {
        var obj = _unitOfWork.EmailTemplate.Get(c => c.Id == id);
        if (obj == null) 
        {
            return NotFound();
        }
        _unitOfWork.EmailTemplate.Delete(obj);
        _unitOfWork.Commit();
        TempData["success"] = "Email Template was deleted Successfully";
        return RedirectToAction("Index");
    }

}

