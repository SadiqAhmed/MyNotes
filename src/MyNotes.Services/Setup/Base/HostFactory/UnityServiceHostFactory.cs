namespace MyNotes.Services.Setup.Base.HostFactory
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.ServiceModel;
    using System.ServiceModel.Activation;
    using MyNotes.Services.Setup.StartupTasks;

    public class UnityServiceHostFactory : ServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(
                                            Type serviceType, Uri[] baseAddresses)
        {
            UnityServiceHost serviceHost = new UnityServiceHost(serviceType, baseAddresses);
            serviceHost.UnityContainer = ServiceDependencyBuilder.UnityContainer;
            return serviceHost;
        }
    }
}