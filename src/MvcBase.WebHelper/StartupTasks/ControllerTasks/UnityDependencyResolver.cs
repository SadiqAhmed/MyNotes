namespace MvcBase.WebHelper.StartupTasks.ControllerTasks
{
    using System;
    using System.Web;
    using System.Collections.Generic;
    using Microsoft.Practices.Unity;
    using System.Web.Mvc;

    public class UnityDependencyResolver : IDependencyResolver
    {
        private IUnityContainer _unityContainer;

        public UnityDependencyResolver(IUnityContainer unityContainer)
        {
            _unityContainer = unityContainer;
        }

        public object GetService(Type serviceType)
        {
            if ((serviceType.IsClass && !serviceType.IsAbstract) || _unityContainer.IsRegistered(serviceType))
                return _unityContainer.Resolve(serviceType);
            return null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            if ((serviceType.IsClass && !serviceType.IsAbstract) || _unityContainer.IsRegistered(serviceType))
                return _unityContainer.ResolveAll(serviceType);

            return new object[] { };
        }
    }
}
