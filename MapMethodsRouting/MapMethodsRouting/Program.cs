var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home page - GET");
    });
    
    endpoints.MapPost("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home page - POST");
    });
    
    endpoints.MapPut("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home page - PUT");
    });
    
    endpoints.MapDelete("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home page - DELETE");
    });
});

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Page not found.");
});

//app.Map("/Home", () => "Hello World!");
//app.MapGet("/Home", () => "Hello World! - from GET request");
//app.MapPost("/Home", () => "Hello World! - from Post request");
//app.MapPut("/Home", () => "Hello World! - from PUT request");
//app.MapDelete("/Home", () => "Hello World! - from DELETE request");


app.Run();

/*
 Map method will work for every request(GET,POST,PUT,DELETE)
Check all the methods from postman.
Endpoint => URL + HTTP method
 */