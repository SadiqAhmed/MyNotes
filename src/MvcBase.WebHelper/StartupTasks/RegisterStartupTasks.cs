namespace MvcBase.WebHelper.StartupTasks
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Web.Mvc;
    using Microsoft.Practices.Unity;
    using MvcBase.WebHelper.StartupTasks.ControllerTasks;

    public class RegisterStartupTasks
    {
        public IUnityContainer Execute(Type[] types)
        {
            IUnityContainer unityContainer = new UnityContainer();

            // setup components
            var components = from t in types
                            where t.GetInterfaces().Contains(typeof(IIncludeComponents))
                                     && null != t.GetConstructor(Type.EmptyTypes)
                            select Activator.CreateInstance(t) as IIncludeComponents;

            foreach (var component in components)
                component.Setup();

            // register dependencies
            var dependencies = from t in types
                            where t.GetInterfaces().Contains(typeof(IRegisterDependency))
                                     && null != t.GetConstructor(Type.EmptyTypes)
                               select Activator.CreateInstance(t) as IRegisterDependency;

            foreach (var dependency in dependencies)
                dependency.Inject(unityContainer);

            DependencyResolver.SetResolver(new UnityDependencyResolver(unityContainer));

            return unityContainer;
        }
    }
}