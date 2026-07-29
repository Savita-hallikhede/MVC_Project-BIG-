using Entity;
using Microsoft.EntityFrameworkCore;

using Service;
using ServiceContracts.DTO;
using ServiceContracts.Interface;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var con = builder.Configuration.GetConnectionString("MVC_Con");

builder.Services.AddDbContext<DbContextdata>(A => A.UseSqlServer(con,b=>b.MigrationsAssembly("Entity")));



//builder.Services.AddDbContext<Dbcontextdata>(A => A.UseSqlServer(builder.Configuration.GetConnectionString("MVC_Con")));

builder.Services.AddScoped<ICountrySC, CountryService>();

var app = builder.Build();
app.UseStaticFiles();

app.UseRouting();
app.MapControllers();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Country}/{action=ADD}/{id?}");
app.Run();
