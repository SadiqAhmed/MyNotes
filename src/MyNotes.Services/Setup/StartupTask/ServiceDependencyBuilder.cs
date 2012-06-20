namespace MyNotes.Services.Setup.StartupTask
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Microsoft.Practices.Unity;

    internal class ServiceDependencyBuilder
    {
        private ServiceDependencyBuilder()
        {
        }

        public static IUnityContainer Container;
        
        /// <summary>
        /// Add IRegisterDependencies to the container
        /// </summary>
        public static void AddDependencies()
        {
            if (null != Container)
            {
                var container = new UnityContainer();

                var instances = from t in Assembly.GetExecutingAssembly().GetTypes()
                                where t.GetInterfaces().Contains(typeof(IRegisterDependency))
                                         && null != t.GetConstructor(Type.EmptyTypes)
                                select Activator.CreateInstance(t) as IRegisterDependency;

                foreach (var instance in instances)
                {
                    instance.Inject(container);
                }
            }
        }
    }
}