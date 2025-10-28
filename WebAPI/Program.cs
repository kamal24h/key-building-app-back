using Common.Configuration;
using Common.DependencyInjection;
using DataAccess;
using Domain.Models;
//using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);



CultureInfo.DefaultThreadCurrentCulture = PersianDateExtensionMethods.GetPersianCulture();
CultureInfo.DefaultThreadCurrentUICulture = PersianDateExtensionMethods.GetPersianCulture();


// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



//builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = false)
//    .AddEntityFrameworkStores<AppDbContext>();



//builder.Services.AddDefaultIdentity<AppUser>()
//           .AddRoles<IdentityRole>()
//           .AddEntityFrameworkStores<AppDbContext>()
//           .AddUserManager<UserManager<AppUser>>()
//           .AddSignInManager()
//           .AddDefaultTokenProviders();

//builder.Services.AddAuthenticationCore();
//builder.Services.AddAuthorizationCore();

//builder.Services.AddAuthentication(o =>
//{
//    o.DefaultScheme = IdentityConstants.ApplicationScheme;
//    o.DefaultSignInScheme = IdentityConstants.ExternalScheme;
//}).AddIdentityCookies(o => { });


//builder.Services.AddDatabaseDeveloperPageExceptionFilter();
//builder.Services.AddHttpContextAccessor();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();


// Config mappings
MapperConfig.ConfiguerServices(builder.Services, builder.Configuration);
// Config Dependency Injections
Bootstrap.ConfigureService(builder.Services, builder.Configuration);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
