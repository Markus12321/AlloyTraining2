using System;
using System.Data.Entity;
using System.Linq;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using AlloyTraining.Business.DependencyResolvers;
using System.Web.Mvc;
using EPiServer.ServiceLocation;

namespace AlloyTraining.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class RegisterDependencyResolverInitializationModule : IConfigurableModule
    {
        public void Initialize(InitializationEngine context)
        {
            //Add initialization logic, this method is called once after CMS has been initialized
        }

        public void Uninitialize(InitializationEngine context)
        {
            //Add uninitialization logic
        }

        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            DependencyResolver.SetResolver(
                new StructureMapDependencyResolver(context.StructureMap()));

            context.ConfigurationComplete += (o, e) =>
            {
                //register custom implementations over default implementation
            };
        }
    }
}