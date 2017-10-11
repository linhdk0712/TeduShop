using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Autofac;
using Autofac.Integration.Mvc;
using System.Reflection;
using TeduShop.Data.Infrastructure;
using TeduShop.Data;
using System.Web.Mvc;
using System.Web.Http;
using Autofac.Integration.WebApi;
using TeduShop.Data.Repositories;
using TeduShop.Services.Services;

[assembly: OwinStartup(typeof(TeduShop.Web.App_Start.Startup))]

namespace TeduShop.Web.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            ConfigAutofac(app);
        }
        private void ConfigAutofac(IAppBuilder app)
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();
            builder.RegisterType<TeduShopDbContext>().AsSelf().InstancePerRequest();



            // repository
            builder.RegisterAssemblyTypes(typeof(FooterRepository).Assembly)
                   .Where(t => t.Name.EndsWith("Repository"))
                   .AsImplementedInterfaces().InstancePerRequest();
            // services
            builder.RegisterAssemblyTypes(typeof(FooterService).Assembly)
                  .Where(t => t.Name.EndsWith("Service"))
                  .AsImplementedInterfaces().InstancePerRequest();
            IContainer container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            var resolver = new AutofacWebApiDependencyResolver((IContainer)container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;

        }
    }
}
