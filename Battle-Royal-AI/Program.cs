var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();


var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.UseStaticFiles();

app.Run();
