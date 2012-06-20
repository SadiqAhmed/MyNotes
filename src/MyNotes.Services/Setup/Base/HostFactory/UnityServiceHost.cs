namespace MyNotes.Services.Setup.Base.HostFactory
{
    using System;
    using System.ServiceModel;
    using Microsoft.Practices.Unity;

    public class UnityServiceHost: ServiceHost
    {
        public IUnityContainer UnityContainer { set; get; }
    
        public UnityServiceHost()
            : base()
        {
            UnityContainer = new UnityContainer();
        }
    
        public UnityServiceHost(Type serviceType, params Uri[] baseAddresses)
            : base(serviceType, baseAddresses)
        {
            UnityContainer = new UnityContainer();
        }
    
        protected override void OnOpening()
        {
            if (this.Description.Behaviors.Find<UnityServiceBehavior>() == null)
                this.Description.Behaviors.Add(new UnityServiceBehavior(UnityContainer));
    
            base.OnOpening();
        }
    }
}