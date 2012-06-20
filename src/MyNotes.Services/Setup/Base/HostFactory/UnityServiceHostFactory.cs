namespace MyNotes.Services.Setup.Base.HostFactory
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.ServiceModel;
    using System.ServiceModel.Activation;
    using MyNotes.Services.Setup.StartupTask;

    public class UnityServiceHostFactory : ServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(
                                            Type serviceType, Uri[] baseAddresses)
        {
            UnityServiceHost serviceHost = new UnityServiceHost(serviceType, baseAddresses);
            serviceHost.Container = ServiceDependencyBuilder.Container;
            return serviceHost;
        }
    }
}