using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using wildcatMicroFund.Interfaces;
using wildcatMicroFund.Models;

[Area("Entrepreneur")]
public class NewApplicationController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public NewApplicationController(IUnitOfWork unitOfWork)//Dependency Injection
    {
        _unitOfWork = unitOfWork;

    }

    public ViewResult Index()
    {
        return View();
    }

    public ViewResult ApplicationForm()
    {
        return View();
    }
}