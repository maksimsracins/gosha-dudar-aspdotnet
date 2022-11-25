using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ShowNew.Data.Interfaces;
using ShowNew.Data.Mocks;

namespace ShowNew {
    public class Startup {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) { //Module-Plagin registration
            services.AddTransient<IAllCars, MockCars>(); //connect Interface and Class that implement interface
            services.AddTransient<ICarsCategory, MockCategory>(); //connect Interface and Class that implement interface
            services.AddMvc(option => option.EnableEndpointRouting = false); // connect MVC
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            app.UseDeveloperExceptionPage(); // show errors
            app.UseStatusCodePages(); // show status of api call
            app.UseStaticFiles(); //show css, imgs and etc.
            app.UseMvcWithDefaultRoute();
        }
    }
}
