using Microsoft.AspNetCore.Mvc;

namespace ErrorHandling.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("error/throw")]
        public IActionResult Throw()
        {
            throw new Exception("This is a test exception.");
        }
    }
}
