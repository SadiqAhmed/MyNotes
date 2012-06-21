namespace MyNotes.DataStorage.DomainObjects.Mappings
{
    using FluentNHibernate.Mapping;
    using MyNotes.DataStorage.DomainObjects.Entities;

    public abstract class EntityBaseMap<T> : ClassMap<T>
        where T : EntityBase
    {
        public EntityBaseMap()
        {
            Id(x => x.Id)
                .GeneratedBy.Guid();
            Map(x => x.IsActive).Default("1")
                .Not.Nullable();
            Map(x => x.CreatedDate)
                .Not.Nullable();
            Map(x => x.LastModifiedDate)
                .Not.Nullable();
        }
    }
}
