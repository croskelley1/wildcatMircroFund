using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using wildcatMicroFund.Interfaces;
using wildcatMicroFund.Models;

[Area("Entrepreneurs")]
public class HomeController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public HomeController(IUnitOfWork unitOfWork)//Dependency Injection
    {
        _unitOfWork = unitOfWork;

    }

    public ViewResult Index()
    {
        return View();
    }
}