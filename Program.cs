using BookGrap.Data; // Caminho: Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Conectando com SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer("Server=localhost;Database=LoginDB;Trusted_Connection=True;"));

builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=index}/{id?}");

app.Run();
