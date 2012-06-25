namespace MyNotes.Services.Setup.StartupTasks.Registrations.AutoMappings
{
    using AutoMapper;
    using MyNotes.DataStorage.DomainObjects.Entities;
    using MyNotes.Services.Dtos;

    internal class UserMappingSetup : IIncludeComponent
    {
        public void Add()
        {
            Mapper.CreateMap<User, UserLoginDto>()
                .ForMember(d => d.GroupName, o => o.MapFrom(s => s.Group.Name));
        }
    }
}