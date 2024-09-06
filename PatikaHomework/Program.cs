var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllerRoute(
    name:"Default",
    pattern:"{controllers=customerorder}/{action=index}");

app.Run();
