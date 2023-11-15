using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Ez is kell az adminhoz.
            builder.Services.AddRouting(options => options.LowercaseUrls = true);







            // További konfigurációs beállítások

            builder.Services.AddDbContext<BookStoreContext>( options => options.UseSqlServer(builder.Configuration.GetConnectionString("BookStoreContext")) );










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



            // ez vezeti rá az admin területre
            app.MapAreaControllerRoute(name: "admin", areaName: "Admin", pattern: "Admin/{controller=Book}/{action=Index}/{id?}");


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}