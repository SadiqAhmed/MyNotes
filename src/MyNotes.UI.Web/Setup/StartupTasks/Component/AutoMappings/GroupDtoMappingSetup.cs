namespace MyNotes.UI.Web.Setup.StartupTasks.Component.AutoMappings
{
    using AutoMapper;
    using MvcBase.WebHelper.StartupTasks;
    using MyNotes.UI.Web.AdminServiceRef;
    using MyNotes.UI.Web.ViewModels.Admin;

    public class GroupDtoMappingSetup : IIncludeComponent
    {
        public void Setup()
        {
            Mapper.CreateMap<GroupDto, GroupViewModel>();
        }
    }
}