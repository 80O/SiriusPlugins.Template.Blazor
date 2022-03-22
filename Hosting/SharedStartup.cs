//using Microsoft.AspNetCore.Mvc.RazorPages;
//using MudBlazor.Services;
//namespace SiriusHouseKeeping
//{
//    public class SharedStartup
//    {
//        public static IServiceCollection ServiceCollection;
//        public static IServiceProvider ServiceProvider;

//        public SharedStartup(IConfiguration configuration)
//        {
//            Configuration = configuration;
//        }

//        public IConfiguration Configuration { get; }

//        // This method gets called by the runtime. Use this method to add services to the container.
//        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
//        public void ConfigureServices(IServiceCollection services)
//        {
//            services.AddRazorPages();
//            services.AddServerSideBlazor();
//            services.AddMudServices();
//            services.Configure<RazorPagesOptions>(options => options.RootDirectory = "/Pages");

//            foreach (var reg in ServiceCollection)
//            {
//                if (reg.ServiceType.IsGenericType) continue;
//                if (reg.Lifetime == ServiceLifetime.Singleton)
//                {
//                    services.AddSingleton(reg.ServiceType, (_) => ServiceProvider.GetService(reg.ServiceType));
//                }
//                if (reg.Lifetime == ServiceLifetime.Transient)
//                {
//                    services.AddTransient(reg.ServiceType, (_) => ServiceProvider.GetService(reg.ServiceType));
//                }
//                if (reg.Lifetime == ServiceLifetime.Scoped)
//                {
//                    services.AddSingleton(reg.ServiceType, (_) => ServiceProvider.GetService(reg.ServiceType));
//                }
//            }
//        }

//        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
//        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//        {
//            if (env.IsDevelopment())
//            {
//                app.UseDeveloperExceptionPage();
//            }
//            else
//            {
//                app.UseExceptionHandler("/Error");
//                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//                app.UseHsts();
//            }
//            app.UseHttpsRedirection();
//            app.UseStaticFiles();

//            app.UseRouting();

//            app.UseEndpoints(endpoints =>
//            {
//                endpoints.MapBlazorHub();
//                endpoints.MapFallbackToPage("/_Host");
//            });
//        }
//    }
//}
