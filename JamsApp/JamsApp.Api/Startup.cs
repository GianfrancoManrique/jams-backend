using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JamsApp.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using AutoMapper;
using JamsApp.Data.Profiles;
using JamsApp.Application.Schedules.Queries.GetSchedules;
using JamsApp.Application.Common;
using JamsApp.Application.Employees.Commands.PostEmployeeAssistance;
using JamsApp.Application.Employees.Queries.GetEmployeeLogin;

namespace JamsApp.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
           services.AddDbContext<DatabaseService>(
           options => options.UseSqlServer(Configuration.GetConnectionString("Jams")));

            services.AddMvc();

            #region Swagger Service
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Jams API", Version = "v1"});
            });
            #endregion

            #region Profiles
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new SchedulesProfile());
                mc.AddProfile(new AssistancesProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            #endregion

            services.AddTransient<IDatabaseService, DatabaseService>();
            services.AddTransient<IDatabaseComplexService, DatabaseComplexService>();
            services.AddTransient<IGetSchedulesQuery, GetSchedulesQuery>();
            services.AddTransient<IGetEmployeeLoginQuery, GetEmployeeLoginQuery>();
            services.AddTransient<IPostEmployeeAssistanceCommand, PostEmployeeAssistanceCommand>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            #region Configure Swagger
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
            #endregion

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                
                /*
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
                */
            });
        }
    }
}
