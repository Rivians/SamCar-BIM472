using SamCar472.Application.Interfaces;
using SamCar472.Application.Interfaces.BlogInterfaces;
using SamCar472.Persistence.Context;
using SamCar472.Persistence.Repositories;
using SamCar472.Persistence.Repositories.BlogRepositories;
using SamCar472.Application.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using SamCar472.Application.Interfaces.CommentInterfaces;
using SamCar472.Persistence.Repositories.CommentRepositories;
using SamCar472.Application.Interfaces.AppUserInterfaces;
using SamCar472.Persistence.Repositories.AppUserRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.Cookie.Name = "NetCoreMvc.Auth";      // Kimlik do�rulama i�in kullan�lan �erezin ad� "NetCoreMvc.Auth" olarak ayarlan�r. Bu �erez, kullan�c�n�n oturum bilgilerini tutar.
    options.LoginPath = "/Login/Index";           // Bu sat�r, kullan�c�n�n kimlik do�rulama gerektiren bir kayna�a eri�meye �al��t���nda y�nlendirilece�i giri� sayfas�n�n yolunu belirtir. 
    options.AccessDeniedPath = "/Login/Index";    // Bu sat�r, kullan�c�n�n yetkilendirilmedi�i bir kayna�a eri�meye �al��t���nda y�nlendirilece�i eri�im reddedildi sayfas�n�n yolunu belirtir.
});

builder.Services.AddApplicationService();

builder.Services.AddScoped<SamCarContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));
builder.Services.AddScoped(typeof(ICommentRepository), typeof(CommentRepository));
builder.Services.AddScoped(typeof(IAppUserRepository), typeof(AppUserRepository));

builder.Services.AddControllersWithViews();

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();