namespace MyNotes.Services.Setup.StartupTasks
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

        public static IUnityContainer UnityContainer {get; private set;}
        
        /// <summary>
        /// Add IRegisterDependencies to the container
        /// </summary>
        public static void AddDependencies()
        {
            if (null == UnityContainer)
            {
                var components = (from t in Assembly.GetExecutingAssembly().GetTypes()
                                where t.GetInterfaces().Contains(typeof(IIncludeComponent))
                                         && null != t.GetConstructor(Type.EmptyTypes)
                                select Activator.CreateInstance(t) as IIncludeComponent).ToList();

                foreach (var component in components)
                    component.Add();
                
                UnityContainer = new UnityContainer();

                var instances = (from t in Assembly.GetExecutingAssembly().GetTypes()
                                where t.GetInterfaces().Contains(typeof(IRegisterDependency))
                                         && null != t.GetConstructor(Type.EmptyTypes)
                                select Activator.CreateInstance(t) as IRegisterDependency).ToList();

                foreach (var instance in instances)
                    instance.Inject(UnityContainer);
            }
        }
    }
}