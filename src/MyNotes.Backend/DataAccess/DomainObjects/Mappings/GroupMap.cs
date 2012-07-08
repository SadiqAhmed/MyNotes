namespace MyNotes.Backend.DataAccess.DomainObjects.Mappings
{
    using FluentNHibernate.Mapping;
    using MyNotes.Backend.DataAccess.DomainObjects.Entities;

    public class GroupMap : EntityBaseMap<Group>
    {
        public GroupMap()
        {
            Map(x => x.Name)
                .Not.Nullable();
            Map(x => x.IsSystem)
                .Not.Nullable();
            HasMany<User>(x => x.Users)
                .Inverse()
                .AsBag()
                .Cascade.SaveUpdate();
        }
    }
}
