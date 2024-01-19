using System.Text;
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

        [HttpPost]
        public IActionResult FormPost(FormRequest request){
            HttpContext.Session.Set("prompt", Encoding.UTF8.GetBytes(request.Prompt));
            return Redirect("/fairytale");
        }
    }

    public class FormRequest {
        public string Prompt {get;set;} = "";
    }
}
