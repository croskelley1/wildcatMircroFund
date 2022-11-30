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

        public ViewResult Index()
        {

            return View();

        }
    }

    
}