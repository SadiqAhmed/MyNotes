namespace MyNotes.Backend.Setup.StartupTasks.Component.AutoMappings
{
    using AutoMapper;
    using MyNotes.Backend.DataAccess.DomainObjects.Entities;
    using MyNotes.Backend.Dtos;

    internal class UserMappingSetup : IIncludeComponent
    {
        public void Add()
        {
            Mapper.CreateMap<User, LoggedUserInfoDto>()
                .ForMember(d => d.GroupId, o => o.MapFrom(s => s.Group.Id))
                .ForMember(d => d.GroupName, o => o.MapFrom(s => s.Group.Name))
                .ForMember(d => d.IsSysAccount, o => o.MapFrom(s => s.Group.IsSysAccount));

            Mapper.CreateMap<User, UserDto>()
                .ForMember(d => d.GroupId, o => o.MapFrom(s => s.Group.Id))
                .ForMember(d => d.GroupName, o => o.MapFrom(s => s.Group.Name));
        }
    }
}