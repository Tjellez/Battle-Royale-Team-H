using Battle_Royal_AI.src;
using Microsoft.AspNetCore.Mvc;

namespace Battle_Royal_AI;

    [Controller]
    [Route("[controller]")]
    public class FairytaleController : Controller
    {
        public IActionResult Index(){
            var model = new FairytaleModel { Prompt = HttpContext.Session.GetString("prompt") ?? ""};

            var fairytaleResponse = ChatGPT.GetGoodNightStory(model.Prompt);
            model.Fairytale = fairytaleResponse;

            var dalleResponse = DALLe.GetDALLeImage(model.Prompt);
            model.Image = dalleResponse.Result;

            return View("~/Fairytale/index.cshtml", model);
        }
    }

    public class FairytaleModel {
        public string Prompt {get;set;} = "";
        public string Title {get;set;} = "";
        public string Fairytale {get;set;} = "";
        public Uri? Image {get;set;} = null;
        public Uri? Sound {get;set;} = null;
    }
