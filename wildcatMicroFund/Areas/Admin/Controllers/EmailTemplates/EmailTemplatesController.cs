using Microsoft.AspNetCore.Mvc;
using wildcatMicroFund.Interfaces;

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
        return View();
    }
}

