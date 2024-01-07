var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// We can use both method for routing
app.MapDefaultControllerRoute();
//app.MapControllerRoute("Deafault", "{controller=Home}/{Action=Index}/{id}");

//app.MapGet("/", () => "Hello Nikita");



app.Run();
