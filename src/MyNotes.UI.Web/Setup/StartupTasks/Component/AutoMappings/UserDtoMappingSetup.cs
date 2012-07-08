namespace MyNotes.UI.Web.Setup.StartupTasks.Component.AutoMappings
{
    using AutoMapper;
    using MvcBase.WebHelper.StartupTasks;
    using MyNotes.UI.Web.UserServiceRef;
    using MyNotes.UI.Web.ViewModels.User;

    public class UserDtoMappingSetup : IIncludeComponent
    {
        public void Setup()
        {
            Mapper.CreateMap<UserDto, UserViewModel>();
        }
    }
}