var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); // for both conventional and attribute base routing
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.MapDefaultControllerRoute(); 
// adds default route => {controller=Home}/{action=Index}/{Id?}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=About}/{id?}"
);

app.MapControllers(); // for attribute routing

app.Run();
