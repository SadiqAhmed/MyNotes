namespace MyNotes.DataStorage.DomainObjects.Mappings
{
    using FluentNHibernate.Mapping;
    using MyNotes.DataStorage.DomainObjects.Entities;

    public class GroupMap : EntityBaseMap<Group>
    {
        public GroupMap()
        {
            Map(x => x.Name)
                .Not.Nullable();
            HasMany<User>(x => x.Users)
                .Inverse()
                .AsBag();
        }
    }
}
