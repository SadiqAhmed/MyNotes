namespace MyNotes.Backend.Setup.Base.HostFactory
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Channels;
    using System.ServiceModel.Dispatcher;
    using Microsoft.Practices.Unity;

    public class UnityInstanceProvider: IInstanceProvider
    {
        public IUnityContainer UnityContainer { set; get; }
        
        public Type ServiceType { set; get; }
    
        public UnityInstanceProvider()
            : this(null)
        {
        }
    
        public UnityInstanceProvider(Type type)
        {
            ServiceType = type;
            UnityContainer = new UnityContainer();
        }
    
        public object GetInstance(InstanceContext instanceContext, Message message)
        {
            return UnityContainer.Resolve(ServiceType);
        }
    
        public object GetInstance(InstanceContext instanceContext)
        {
            return GetInstance(instanceContext, null);
        }
        public void ReleaseInstance(InstanceContext instanceContext, object instance)
        {
        }
    }
}