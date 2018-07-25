using Autofac;
using Gestor.CuotaCobradaServiceAdapter;
using Gestor.ResumenTarjetaCobradoAdapter;
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

            // configure your container
            // e.g. builder.RegisterModule<TestOverrideModule>();
            builder.RegisterType<ResumenTarjetaCobradoService>().As<IResumenTarjetaCobradoService>();
            builder.RegisterType<CuotaCobradaService>().As<ICuotaCobradaService>();

            Container = builder.Build();
        }

    }
}
