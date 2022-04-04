using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using repositoryPattern_Demo.Models.Repository;
using repositoryPattern_Demo.Models.Collections;
using repositoryPattern_Demo.Models.MongoDB;
using repositoryPattern_Demo.Models.SQLServer;
namespace repositoryPattern_Demo
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
            services.AddSingleton<IProductRepository, ProductSQlServer>();
            services.AddControllers();
            services.AddCors(options =>
           {
               options.AddDefaultPolicy(builder =>
               {
                   builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();

               });

               options.AddPolicy("ClientA", builder => {
                   builder.WithOrigins("http://www.clietna.com").AllowAnyOrigin().AllowAnyMethod();

               });

           });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "repositoryPattern_Demo", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "repositoryPattern_Demo v1"));
            }

            app.UseHttpsRedirection();
            app.UseCors(); //this will configure cors for alll the controller in your applicaation
                            //lets say you had 20 controller, policy gets applied to all 20
                               //you may not want this.
                               //so you can put it on the controller
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
