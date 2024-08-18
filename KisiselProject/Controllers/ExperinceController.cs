using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers{

public class ExperienceController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
}