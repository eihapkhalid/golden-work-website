using Bl;
using Bl.Interfaces;
using Bl.Repositories;
using Bl.Services;
using Domains;
using Microsoft.EntityFrameworkCore;

namespace GoldenWorkWebsite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<GoldenDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            #region Add scope 
            //Add scope for TbUser,TbBankAccount,TbPayment (dependcy injection)
            builder.Services.AddScoped<IGenericRepository<TbUser>, UserRepository>();
            builder.Services.AddScoped<IBusinessLayer<TbUser>, UserService>();

            builder.Services.AddScoped<IGenericRepository<TbTechnician>, TechnicianRepository>();
            builder.Services.AddScoped<IBusinessLayer<TbTechnician>, TechnicianService>();

            builder.Services.AddScoped<IGenericRepository<TbService>, ServiceRepository>();
            builder.Services.AddScoped<IBusinessLayer<TbService>, ServiceService>();

            builder.Services.AddScoped<IGenericRepository<TbNews>, NewsRepository>();
            builder.Services.AddScoped<IBusinessLayer<TbNews>, NewsService>();

            builder.Services.AddScoped<IGenericRepository<TbCustomer>, CustomerRepository>();
            builder.Services.AddScoped<IBusinessLayer<TbCustomer>, CustomerService>();

            builder.Services.AddScoped<IGenericRepository<TbCustomerReview>, CustomerReviewRepository>();
            builder.Services.AddScoped<IBusinessLayer<TbCustomerReview>, CustomerReviewService>();

            builder.Services.AddScoped<IGenericRepository<TbContact>, ContactRepository>();
            builder.Services.AddScoped<IBusinessLayer<TbContact>, ContactService>();

            builder.Services.AddScoped<IGenericRepository<TbBooking>, BookingRepository>();
            builder.Services.AddScoped<IBusinessLayer<TbBooking>, BookingService>();

            builder.Services.AddScoped<IGenericRepository<TbAbout>, AboutRepository>();
            builder.Services.AddScoped<IBusinessLayer<TbAbout>, AboutService>();

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            #endregion

            var app = builder.Build();
            //Add dbcontext :
           

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

            #region UseEndpoints routing
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "admin",
                    pattern: "{area:exists}/{controller=PaymentAdmin}/{action=Index}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            #endregion

            app.Run();
        }
    }
}