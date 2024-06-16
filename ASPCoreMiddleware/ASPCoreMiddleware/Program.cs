var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.run(async (context) =>
//{
//    await context.response.writeasync("welcome to asp .net core");
//});

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Welcome to ASP .NET Core \n");
//    await next(context);
//});

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("I am learning C#");
//});

// if  your  next(context) are not working then use next.invoke().

app.Use(async (Context, next) =>
{
    await Context.Response.WriteAsync("If you create multiple middleware, use Use instead of Run \n");
    await next.Invoke();
});

app.Use(async (Context, next) =>
{
    await Context.Response.WriteAsync("another middleware \n");
    await next.Invoke();
});

app.Run(async (Context) =>
{
    await Context.Response.WriteAsync("its asp.net core custom middleware");
});

app.Run();
