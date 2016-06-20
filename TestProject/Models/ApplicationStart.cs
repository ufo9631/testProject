using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace TestProject.Models
{
    public class ApplicationStart
    {
        public static void Dependency()
        {
            var builder = new ContainerBuilder();

            var datadal = Assembly.Load("DAL");
            builder.RegisterAssemblyTypes(datadal).Where(a => a.FullName.Contains("DAL")).AsImplementedInterfaces();

            var databll = Assembly.Load("BLL");
            builder.RegisterAssemblyTypes(databll).Where(a => a.FullName.Contains("BLL")).AsImplementedInterfaces();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
           // builder.RegisterInstance(new DbEntities()).As<DbEntities>();
            var contain = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(contain));

        }
    }
}