using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.DataProtection;
using Owin;
using TeduShop.Data;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Infrastructure.Interfaces;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;
using TeduShop.Services.Services;
using TeduShop.Web.App_Start;
using Startup = TeduShop.Web.Startup;

[assembly: OwinStartup(typeof(Startup))]

namespace TeduShop.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            ConfigAutofac(app);
            ConfigureAuth(app);
        }
        private static void ConfigAutofac(IAppBuilder app)
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();
            builder.RegisterType<TeduShopDbContext>().AsSelf().InstancePerRequest();
            //Asp.net Identity
            builder.RegisterType<ApplicationUserStore>().As<IUserStore<ApplicationUser>>().InstancePerRequest();
            builder.RegisterType<ApplicationUserManager>().AsSelf().InstancePerRequest();
            builder.RegisterType<ApplicationSignInManager>().AsSelf().InstancePerRequest();
            builder.Register(c => HttpContext.Current.GetOwinContext().Authentication).InstancePerRequest();
            builder.Register(c => app.GetDataProtectionProvider()).InstancePerRequest();


            // repository
            builder.RegisterAssemblyTypes(typeof(PostCategoryRepository).Assembly)
                   .Where(t => t.Name.EndsWith("Repository"))
                   .AsImplementedInterfaces().InstancePerRequest();
            // services
            builder.RegisterAssemblyTypes(typeof(PostCategoryService).Assembly)
                  .Where(t => t.Name.EndsWith("Service"))
                  .AsImplementedInterfaces().InstancePerRequest();
            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;

        }
    }
}
