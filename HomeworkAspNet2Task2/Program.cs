using HomeworkAspNet2Task2;
using HomeworkAspNet2Task2.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ApplicationDbContext>(o =>
	o.UseSqlServer("Server=DESKTOP-SC48M2E\\SQLEXPRESS;Database=HomeworkAspNet2;Trusted_Connection=True;TrustServerCertificate=True")); // Use the configuration
var shapeService = new ShapeService();
builder.Services.AddSingleton(shapeService);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
