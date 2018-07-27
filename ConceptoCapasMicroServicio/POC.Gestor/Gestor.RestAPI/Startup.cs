using AutoMapper;
using Gestor.API;
using Gestor.CuotaCobradaServiceAdapter;
using Gestor.CuotaCobradaServiceAdapter.Proxy;
using Gestor.ResumenTarjetaCobradoAdapter;
using Gestor.ResumenTarjetaCobradoServiceAdapter.Proxy;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Examples;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;

namespace Gestor.RestAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            //Configuracion de mapeos.
            Mapper.Initialize(cfg => cfg.AddProfiles(new[] {
                typeof(CuotaCobradaServiceAdapter.Mappers.AutomapperConfig),
                typeof(ResumenTarjetaCobradoServiceAdapter.Mappers.AutomapperConfig),
                typeof(Gestor.RestAPI.Mappers.AutomapperConfig)
            }));
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //registro la Inyeccion
            services.AddTransient<IManagerCobranza, ManagerCobranza>();
            services.AddTransient<IResumenTarjetaCobradoService, ResumenTarjetaCobradoService>();
            services.AddTransient<ICuotaCobradaService, CuotaCobradaServiceAdapter.CuotaCobradaService>();
            services.AddTransient<ICuotaCobradaServiceProxy, MockCuotaCobradaProxy>();
            services.AddTransient<IResumenTarjetaCobradoProxy, MockResumenTarjetaCobradoProxy>();
                       

            services
                .AddSwaggerGen(c =>
                {
                    c.CustomSchemaIds(x => x.FullName);
                    c.SwaggerDoc("v1", new Info { Title = "POC Service", Version = "v1" });

                    var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                    var xmlPath = Path.Combine(basePath, "Gestor.RestApi.xml");

                    c.IncludeXmlComments(xmlPath);
                    c.OperationFilter<ExamplesOperationFilter>();
                })
                .AddMvc(options =>
                {
                    options.Filters.Add(new ProducesAttribute("application/json"));
                    options.Filters.Add(new AllowAnonymousFilter());
                });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
           
            app
                .UseMvc()
                .UseSwagger(c => c.RouteTemplate = "docs/{documentName}/swagger.json")
                .UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/docs/v1/swagger.json", "POC Service V1");
                    c.RoutePrefix = "help";
                    c.DefaultModelsExpandDepth(-1);
                });
        }

        
    }
}
