namespace MyNotes.Backend.Service.Implementations
{
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using log4net;
    using MyNotes.Backend.Service.Contracts;
    using System;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EchoService" in code, svc and config file together.
    public class EchoService : IEchoService
    {
        ILog _logger;

        public EchoService(ILog logger)
        {
            _logger = logger;
        }

        public string Ping()
        {
            return DateTime.Now.ToLongTimeString();
        }
    }
}
