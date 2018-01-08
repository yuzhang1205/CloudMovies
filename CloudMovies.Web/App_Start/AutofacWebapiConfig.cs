using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Autofac.Integration.WebApi;
using System.Data.Entity;
using CloudMovies.Entities;
using CloudMovies.Infrastructure;
using CloudMovies.Repositories;
using CloudMovies.Services;
using CloudMovies.Services.Abstract;

namespace CloudMovies.Web.App_Start
{
    public class AutofacWebapiConfig
    {
        public static IContainer Container;
        public static void Initiaze(HttpConfiguration config)
        {
            Initiaze(config, RegisterServices(new ContainerBuilder()));
        }
        public static void Initiaze(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
        public static IContainer RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<CloudMoviesContext>().As<DbContext>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterGeneric(typeof(EntityBaseRepository<>)).As(typeof(IEntityBaseRepository<>)).InstancePerRequest();

            builder.RegisterType<EncryptionService>().As<IEncryptionService>().InstancePerRequest();

            builder.RegisterType<MembershipService>()
            .As<IMembershipService>()
            .InstancePerRequest(); 
            Container = builder.Build();
            return Container;
        }
    }
}