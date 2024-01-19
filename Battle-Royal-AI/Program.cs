using Battle_Royal_AI.src;
using static System.Runtime.InteropServices.JavaScript.JSType;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
builder.Services.AddSession();


var app = builder.Build();
app.UseSession();
app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.UseStaticFiles();

app.Run();


// Take in prompt from frontend
var storyPrompt = "Can you tell me a story about a dragon and an elf?";
var response = ChatGPT.GetGoodNightStory(storyPrompt);
var prompt = response.Value.Choices[0].Message.Content.Substring(0, 100);
var imageUri = await DALLe.GetDALLeImage(prompt);
// Send image uri and story text to frontend
