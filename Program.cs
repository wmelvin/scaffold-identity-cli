using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using src.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("srcIdentityDbContextConnection") ?? throw new InvalidOperationException("Connection string 'srcIdentityDbContextConnection' not found.");

builder.Services.AddDbContext<srcIdentityDbContext>(options =>
    options.UseSqlite(connectionString));

builder.Services.AddDefaultIdentity<DemoUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<srcIdentityDbContext>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment()) 
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();
app.UseAuthentication();;

app.Run();
