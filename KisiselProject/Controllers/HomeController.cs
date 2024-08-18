using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers{

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
}