using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace Battle_Royal_AI;

    [Controller]
    [Route("[controller]")]
    public class FairytaleController : Controller
    {
        public IActionResult Index(){
            var model = new FairytaleModel { Prompt = HttpContext.Session.GetString("prompt") ?? ""};
            return View("~/Fairytale/index.cshtml", model);
        }
    }

    public class FairytaleModel {
        public string Prompt {get;set;} = "";
        public string Title {get;set;} = "";
        public string Fairytale {get;set;} = "";
        public string Image {get;set;} = "";
        public Uri? Sound {get;set;} = null;
    }
