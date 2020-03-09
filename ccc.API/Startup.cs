using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using ccc.API.Features.Users;
using ccc.API.Features.Players;

namespace ccc.API
{
    public partial class Startup
    {
        private MapperConfiguration _mapperConfiguration { get; set; }

        public Startup(IHostEnvironment env)
        {
            //Set up AutoMapper
            _mapperConfiguration = new MapperConfiguration(config =>
            {
                config.AddProfile(new PlayersMapProfile());
                config.AddProfile(new UsersMapProfile());
            });

            var builder = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
            .AddJsonFile("localConnectionStrings.json", optional: true);

            if (env.IsEnvironment("Development"))
            {
                //dev specific things
            }

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            ConfigureCorsServices(services);
            services.AddMvc().AddNewtonsoftJson(options =>
                options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver());
            ConfigureOrmServices(Configuration, services);
            ConfigureAuthServices(Configuration, services);
            ConfigureSwaggerServices(services);
            services.AddSingleton(sp => _mapperConfiguration.CreateMapper());
            ConfigureScopedServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostEnvironment env, IServiceProvider services, ILoggerFactory loggerFactory)
        {
            //loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            //loggerFactory.AddDebug();
            app.UseRouting();

            ConfigureCors(app, env);

            ConfigureOrm(app, env);

            // CAIU.Common.Startup.LogErrorsAndReturnFriendlyResponseToClient<OasisContext>(app, env, loggerFactory);
            ConfigureErrors(app, services, loggerFactory);

            ConfigureAuth(app, env, loggerFactory, Configuration);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            ConfigureSwagger(app, env);
        }
    }
}
