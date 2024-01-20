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
        public IActionResult FormPost([FromForm]string input ){
            if (!ModelState.IsValid)
            {
                // Log or debug ModelState errors
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                // Handle errors appropriately
                return BadRequest(ModelState);
            }

            HttpContext.Session.Set("prompt", Encoding.UTF8.GetBytes(input));
            return Redirect("/fairytale");
        }
    }

    public class FormRequest {
        public string input {get;set;} = "";
    }
}
