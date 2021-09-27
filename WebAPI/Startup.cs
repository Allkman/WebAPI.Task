using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using WebAPI.AutoMapper;
using HomeWorkTask.Application.FactoryServices.Interfaces;
using HomeWorkTask.Application.yServices;
using HomeWorkTask.Application.FactoryServices;
using Microsoft.EntityFrameworkCore;
using HomeWorkTask.Data;

namespace WebAPI
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
            //services.Configure<>(_configuration.GetSection(""));
            services.AddDbContext<HomeWorkTaskDbContext>(opt => opt.UseSqlServer(Configuration["ConnectionString:EfDbOption"]));

            services.AddTransient<IConsoleFactory, ConsoleFactory>();
            services.AddTransient<IEmailFactory, EmailFactory>();
            services.AddTransient<IWriteToFileFactory, WriteToFileFactory>();
            services.AddTransient<IDbFactory, DbFactory>();

            services.ConfigureAutomapper();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
