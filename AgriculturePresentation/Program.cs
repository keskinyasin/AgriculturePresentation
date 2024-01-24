using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate.EntityFramework; // Add this using directive
using DataAccessLayer.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Security.Cryptography.X509Certificates;

namespace AgriculturePresentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CertificateFiles myClass = new CertificateFiles();
            myClass.LoadCertificate();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.UseStartup<Startup>()
                .UseKestrel(options =>
                {
                    options.Listen(System.Net.IPAddress.Loopback, 7025);
                });
        });


        public class Startup
        {
            private IConfiguration Configuration { get; }

            public Startup(IConfiguration configuration)
            {
                Configuration = configuration;
            }

            public void ConfigureServices(IServiceCollection services)
            {
                services.AddScoped<IServiceService, ServiceManager>();
                services.AddScoped<IServiceDal, EfServiceDal>();
                services.AddScoped<ITeamService, TeamManager>();
                services.AddScoped<ITeamDal, EfTeamDal>();
                services.AddScoped<IAnnouncementService, AnnouncementManager>();
                services.AddScoped<IAnnouncementsDal, EfAnnouncementDal>();
                services.AddScoped<IImageService, ImageManager>();
                services.AddScoped<IImageDal, EfImageDal>();
                services.AddControllersWithViews();
                services.AddDbContext<AgricultureContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            }

            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }
                else
                {
                    app.UseExceptionHandler("/Home/Error");
                    app.UseHsts();
                }

                app.UseStaticFiles();

                app.UseRouting();

                app.UseAuthorization();

                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}");
                });
            }
        }
    }
}
