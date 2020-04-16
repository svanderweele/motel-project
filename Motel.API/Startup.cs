using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Motel.API.Classes;
using Motel.API.Models;

namespace Motel.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddDbContext<MotelContext>(options =>
            // {
            //     options.UseLazyLoadingProxies();
            //     options.UseInMemoryDatabase("Dev");
            // });

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins(new[] { "http://localhost:8080" })
                                                .AllowAnyHeader()
                                                .AllowAnyMethod();
                });
            });

            services.AddDbContext<MotelContext>(options =>
            {
                options.UseLazyLoadingProxies();
                options.UseMySql(Configuration.GetConnectionString("DefaultConnection"), options =>
                {
                    options.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
                });
            });

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseCors();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
