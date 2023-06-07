using BreakingNews.Service.ViewModels.Products;
using Microsoft.AspNetCore.Mvc;

namespace BreakingNews.Web.Areas.Administrator.Controllers
{
    [Route("administrator")]
    public class PostController : ControllerBase
    {
        [HttpGet("post")]
        [HttpPost("post")]
        public IActionResult Post(NewViewModel newView)
        {
            Console.WriteLine(1);
            return View();

        }
    }
}
