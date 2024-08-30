using Microsoft.EntityFrameworkCore;
using SchoolMVC.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<SchoolDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("nwCnstring")));
builder.Services.AddScoped<ITeacherRepo, TeacherRepo>();
builder.Services.AddScoped<ISubjectRepo, SubjectRepo>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Subject}/{action=Index}/{id?}");

app.Run();
