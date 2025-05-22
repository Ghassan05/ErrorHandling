using ErrorHandling.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace ErrorHandling.Web.Controllers
{
    public class HomeController : Controller
    {
        static SlowService slowService = new SlowService();

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


        [HttpGet("/slow")]
        public async Task<IActionResult> SlowAsync()
        {
            await slowService.DoSlowWork();
            return View();
        }
    }
}
