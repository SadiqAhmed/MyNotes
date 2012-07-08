namespace MyNotes.Backend.Setup.StartupTasks.Component.AutoMappings
{
    using AutoMapper;
    using MyNotes.Backend.DataAccess.DomainObjects.Entities;
    using MyNotes.Backend.Dtos;

    internal class GroupMappingSetup : IIncludeComponent
    {
        public void Add()
        {
            Mapper.CreateMap<Group, GroupDto>();
        }
    }
}