using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using wildcatMicroFund.Interfaces;
using wildcatMicroFund.Models;

namespace wildcatMicroFund.Controllers
{
    [Area("Entrepreneur")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

    public HomeController(IUnitOfWork unitOfWork)//Dependency Injection
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

    public ViewResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}