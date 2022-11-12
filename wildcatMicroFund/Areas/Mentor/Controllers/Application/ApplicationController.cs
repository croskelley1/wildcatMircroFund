using Microsoft.AspNetCore.Mvc;
using wildcatMicroFund.Models;
using wildcatMicroFund.Interfaces;

[Area("Mentor")]
public class ApplicationController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public ApplicationController(IUnitOfWork unitOfWork)//Dependency Injection
    {
        _unitOfWork = unitOfWork;

    }

    public ViewResult Index()
    {
        IEnumerable<Application> objApplicationsList = _unitOfWork.Application.GetAll(); //_unitOfWork is the database, Applications is the table, GetAll puts rows in a list
        return View(objApplicationsList);
    }

  
    [HttpGet]
    public ViewResult Create()
    {
        return View();

    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Application obj)
    {
        
        if (ModelState.IsValid)
        {
            _unitOfWork.Application.Add(obj); //internal add
            _unitOfWork.Commit(); //physical commit to DB table
            TempData["success"] = "Application created Successfully";
            return RedirectToAction("Index");
        }
        return View(obj);
    }

    [HttpGet]
    public IActionResult Edit(int? id)
    {
        if (id == null || id == 0)
            return NotFound();

        //grab that Application from the DB itself

        var ApplicationFromDb = _unitOfWork.Application.Get(c => c.Id == id);

        if (ApplicationFromDb == null)
        {
            return NotFound();
        }

        return View(ApplicationFromDb);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Application obj)
    {
        
        if (ModelState.IsValid)
        {
            _unitOfWork.Application.Update(obj);
            _unitOfWork.Commit();
            TempData["success"] = "Application updated Successfully";
            return RedirectToAction("Index");
        }
        return View(obj);
    }

    [HttpGet]
    public IActionResult Delete(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }

        var ApplicationFromDb = _unitOfWork.Application.Get(c => c.Id == id);

        if (ApplicationFromDb == null)
        {
            return NotFound();
        }

        return View(ApplicationFromDb);

    }


    [HttpPost, ActionName("Delete")]

    public IActionResult DeletePost(int? id)
    {
        var obj = _unitOfWork.Application.Get(c => c.Id == id);
        if (obj == null)
        { return NotFound(); }

        _unitOfWork.Application.Delete(obj);
        _unitOfWork.Commit();
        TempData["success"] = "Application was deleted Successfully";
        return RedirectToAction("Index");
    }

}