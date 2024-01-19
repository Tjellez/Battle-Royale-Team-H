using Microsoft.AspNetCore.Mvc;

namespace YourNamespace
{
    [Controller]
    [Route("[controller]")]
    public class WelcomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View("~/Welcome/index.cshtml");
        }
    }
}
