namespace MyNotes.Services.Implementations
{
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using log4net;
    using MyNotes.Services.Contracts;
    using MyNotes.Services.Dtos;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EchoService" in code, svc and config file together.
    public class UserService : IUserService
    {
        ILog _logger;

        public UserService(ILog logger)
        {
            _logger = logger;
        }

        public UserLoginDto UserAuthentication(string username, string password)
        {
            return new UserLoginDto();
        }
    }
}
