namespace MyNotes.Backend.DataAccess.DomainObjects.Mappings
{
    using FluentNHibernate.Mapping;
    using MyNotes.Backend.DataAccess.DomainObjects.Entities;

    internal class AccountMap : EntityBaseMap<Account>
    {
        public AccountMap()
        {
            Map(x => x.CurrencyType)
                .Not.Nullable();
            References(x => x.User)
                .Not.Nullable();
            HasMany<Transaction>(x => x.Transactions)
                .Inverse()
                .AsBag()
                .Cascade.SaveUpdate();
        }
    }
}
