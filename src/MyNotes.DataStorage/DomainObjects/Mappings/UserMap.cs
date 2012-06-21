namespace MyNotes.DataStorage.DomainObjects.Mappings
{
    using FluentNHibernate.Mapping;
    using MyNotes.DataStorage.DomainObjects.Entities;

    public class UserMap : EntityBaseMap<User>
    {
        public UserMap()
        {
            Map(x => x.FirstName)
                .Not.Nullable();
            Map(x => x.LastName)
                .Not.Nullable();
            Map(x => x.Nickname);
            Map(x => x.Username)
                .Not.Nullable();
            Map(x => x.Password)
                .Not.Nullable();
            References(x => x.Group)
                .Not.Nullable();
            HasMany<Account>(x => x.Accounts)
                .Inverse()
                .AsBag();
        }
    }
}
