using Autofac;
using Autofac.Integration.Wcf;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace AutofacDemoWCF
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            var builder = new ContainerBuilder();

            // Register your service implementations.
            builder.RegisterType<AutofacDemoWCF.Service1>();
            builder.RegisterType<Soma>().As<ICalculo>().InstancePerLifetimeScope();

            builder.Register<ConnectionMultiplexer>(c => ConnectionMultiplexer.Connect("localhost:13919,password=senhadoredis")).SingleInstance();
            builder.Register<IDatabase>(c => c.Resolve<ConnectionMultiplexer>().GetDatabase());

            // Set the dependency resolver.
            AutofacHostFactory.Container = builder.Build();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}