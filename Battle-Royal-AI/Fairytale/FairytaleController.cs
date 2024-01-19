using Microsoft.AspNetCore.Mvc;

namespace YourNamespace
{
    [Controller]
    [Route("[controller]")]
    public class FairytaleController : Controller
    {
        public IActionResult Index(){
            return View("~/Fairytale/index.cshtml");
        }
    }
}
