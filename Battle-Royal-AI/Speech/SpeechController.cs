using Microsoft.AspNetCore.Mvc;
using Microsoft.CognitiveServices.Speech;
using Microsoft.VisualBasic;

namespace Battle_Royal_AI.Welcome.Speech
{
    [ApiController]
    [Route("api/[controller]")]
    public class SpeechController : ControllerBase
    {
        SpeechConfig config = SpeechConfig.FromSubscription("cfe6ef316bf741918a72044d3e202fab", "eastus");
        Uri speechUri = new Uri(" https://eastus.api.cognitive.microsoft.com/");
        public SpeechController()
        {
            config.SpeechSynthesisVoiceName = "en-US-AriaNeural";
        }

        [HttpPost]
        public async Task<byte[]> GenerateAudio(SpeechRequest request){

            using (var syntesizer = new SpeechSynthesizer(config)){
                var result = await syntesizer.SpeakTextAsync(request.Prompt);
                HttpContext.Response.ContentType = "audio/wav";
                return result.AudioData;
                
            }
        }
    }

    public class SpeechRequest {
        public string? Prompt {get;set;} 
    }
}
