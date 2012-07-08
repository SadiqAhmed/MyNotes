namespace MyNotes.Backend.Setup.StartupTasks.Component.AutoMappings
{
    using AutoMapper;
    using MyNotes.Backend.DataAccess.DomainObjects.Entities;
    using MyNotes.Backend.Dtos;

    internal class UserMappingSetup : IIncludeComponent
    {
        public void Add()
        {
            Mapper.CreateMap<User, UserLoginDto>()
                .ForMember(d => d.GroupId, o => o.MapFrom(s => s.Group.Id))
                .ForMember(d => d.GroupName, o => o.MapFrom(s => s.Group.Name));
        }
    }
}