using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardinalWebApi.Hubs;
using CardinalWebApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;

namespace CardinalWebApi
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
            //services.AddCors(options => options.AddPolicy("CorsPolicy",
            //builder =>
            //{
            //    builder.AllowAnyMethod().AllowAnyHeader()
            //           .WithOrigins("http://localhost:58403/")
            //           .AllowCredentials();
            //}));
            //services.AddHttpsRedirection(options =>
            //{
            //    options.RedirectStatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status307TemporaryRedirect;
            //    options.HttpsPort = 5001;
            //});
            services.AddMvc();

            services.AddDbContext<CardinalDbContext>(options =>
                options.UseSqlServer(Configuration[Constants.CardinalDbConnection]));

            services.AddSignalR(hubOptions => 
                    {
                        hubOptions.EnableDetailedErrors = true;
                    })
                    .AddJsonProtocol(options =>
                    {
                        options.PayloadSerializerSettings.ContractResolver =
                                new CamelCasePropertyNamesContractResolver();
                    });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSignalR(routes =>
            {
                routes.MapHub<TabsHub>("/TabsHub");
            });
            //app.UseCors("CorsPolicy");
            app.UseMvc();
        }
    }
}
