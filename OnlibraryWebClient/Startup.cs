using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnlibraryWebClient.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OnlibraryWebClient
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
            services.AddControllersWithViews();
            services.AddRazorPages();
            //services.AddScoped<HttpClient, HttpClient>(cl => new HttpClient() {BaseAddress = new Uri(@"https://localhost:44372/api") });
            services.AddScoped<HttpClient, HttpClient>(cl => new HttpClient() { BaseAddress = new Uri(Configuration.GetSection("OnlibraryOrdersAPI").Value) });

            //services.AddScoped<GraphQLHttpClient, GraphQLHttpClient>(cl => new GraphQLHttpClient("https://localhost:5001/graphql", new NewtonsoftJsonSerializer()));
            services.AddScoped<GraphQLHttpClient, GraphQLHttpClient>(cl => new GraphQLHttpClient(Configuration.GetSection("OnlibraryWebGraphQL").Value, new NewtonsoftJsonSerializer()));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
