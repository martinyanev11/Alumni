using Alumni.Data.Data;
using Alumni.Data.Models;
using Alumni.Services.ServicesForNews;
using Alumni.Services.ServicesForEvents;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configure database connection
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
	?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<AlumniDbContext>(options =>
	options.UseSqlServer(connectionString));

// Add Identity with custom User and GUID-based IdentityRole
builder.Services.AddIdentity<User, IdentityRole<Guid>>(options =>
{
	options.SignIn.RequireConfirmedAccount = true;
})
.AddEntityFrameworkStores<AlumniDbContext>()
.AddDefaultTokenProviders();

// Add Authorization (required for [Authorize], UseAuthorization, etc.)
builder.Services.AddAuthorization();

builder.Services.ConfigureApplicationCookie(options =>
{
	options.LoginPath = "/Identity/Account/Login";         
	options.AccessDeniedPath = "/Identity/Account/AccessDenied"; 
});

// MVC and Razor Pages
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// Add development exception filter
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Register your custom services
builder.Services.AddScoped<INewsService, NewsServices>();
builder.Services.AddScoped<IEventServices, EventServices>();
// builder.Services.AddScoped<ICharityDonationService, CharityDonationService>();

var app = builder.Build();

// Middleware pipeline
if (app.Environment.IsDevelopment())
{
	app.UseMigrationsEndPoint();
}
else
{
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}");

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
