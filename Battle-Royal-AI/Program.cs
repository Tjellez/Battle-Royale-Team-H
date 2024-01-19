var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
builder.Services.AddSession();


var app = builder.Build();
app.UseSession();
app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.UseStaticFiles();

app.Run();
