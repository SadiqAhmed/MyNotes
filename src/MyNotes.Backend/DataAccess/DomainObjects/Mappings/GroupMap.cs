namespace MyNotes.Backend.DataAccess.DomainObjects.Mappings
{
    using FluentNHibernate.Mapping;
    using MyNotes.Backend.DataAccess.DomainObjects.Entities;

    internal class GroupMap : EntityBaseMap<Group>
    {
        public GroupMap()
        {
            Map(x => x.Name)
                .Not.Nullable();
            HasMany<User>(x => x.Users)
                .Inverse()
                .AsBag()
                .Cascade.SaveUpdate();
        }
    }
}
