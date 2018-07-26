using Autofac;
using AutoMapper;
using Gestor.CuotaCobradaServiceAdapter;
using Gestor.CuotaCobradaServiceAdapter.Proxy;
using Gestor.ResumenTarjetaCobradoAdapter;
using Gestor.ResumenTarjetaCobradoServiceAdapter.Proxy;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xunit;
using Xunit.Abstractions;
using Xunit.Ioc.Autofac;
using Xunit.Sdk;

[assembly: TestFramework("Gestor.API.Test.ConfigureTestFramework", "Gestor.API.Test")]

namespace Gestor.API.Test
{
    public class ConfigureTestFramework : AutofacTestFramework
    {
        private const string TestSuffixConvention = "Tests";

        public ConfigureTestFramework(IMessageSink diagnosticMessageSink)
            : base(diagnosticMessageSink)
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t => t.Name.EndsWith(TestSuffixConvention));

            builder.Register(context => new TestOutputHelper())
                .AsSelf()
                .As<ITestOutputHelper>()
                .InstancePerLifetimeScope();

            //Configuracion DI.
            builder.RegisterType<ResumenTarjetaCobradoService>().As<IResumenTarjetaCobradoService>();
            builder.RegisterType<CuotaCobradaServiceAdapter.CuotaCobradaService>().As<ICuotaCobradaService>();
            builder.RegisterType<MockCuotaCobradaProxy>().As<ICuotaCobradaServiceProxy>();
            builder.RegisterType<MockResumenTarjetaCobradoProxy>().As<IResumenTarjetaCobradoProxy>();

            Container = builder.Build();

            //Configuracion de mapeos.
            Mapper.Initialize(cfg => cfg.AddProfiles(new[] {
                typeof(CuotaCobradaServiceAdapter.Mappers.AutomapperConfig),
                typeof(ResumenTarjetaCobradoServiceAdapter.Mappers.AutomapperConfig)
            }));

           
        }

    }
}
