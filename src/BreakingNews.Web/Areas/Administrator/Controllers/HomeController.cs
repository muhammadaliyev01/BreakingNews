using Microsoft.AspNetCore.Mvc;

namespace BreakingNews.Web.Areas.Administrator.Controllers;
public class HomeController : ControllerBase
{
    public IActionResult Index()
    {
        return View();
    }
}
