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