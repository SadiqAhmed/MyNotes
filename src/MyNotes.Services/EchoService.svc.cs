namespace MyNotes.Services
{
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using log4net;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EchoService" in code, svc and config file together.
    public class EchoService : IEchoService
    {
        ILog _logger;

        public EchoService(ILog logger)
        {
            _logger = logger;
        }

        public string PrintName(string name)
        {
            _logger.Info(string.Format("PrintName was called with parameter - {0}", name));
            return string.Format("Hello world, by {0}", name);
        }
    }
}
