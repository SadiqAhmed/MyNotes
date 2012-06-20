namespace MyNotes.Console.Setup.StartupTasks
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Microsoft.Practices.Unity;

    internal class ConsoleDependencyBuilder
    {
        private ConsoleDependencyBuilder()
        {
        }

        public static IUnityContainer UnityContainer {get; private set;}
        
        /// <summary>
        /// Add IRegisterDependencies to the container
        /// </summary>
        public static void AddDependencies()
        {
            if (null != UnityContainer)
            {
                UnityContainer = new UnityContainer();

                var instances = from t in Assembly.GetExecutingAssembly().GetTypes()
                                where t.GetInterfaces().Contains(typeof(IRegisterDependency))
                                         && null != t.GetConstructor(Type.EmptyTypes)
                                select Activator.CreateInstance(t) as IRegisterDependency;

                foreach (var instance in instances)
                {
                    instance.Inject(UnityContainer);
                }
            }
        }
    }
}