namespace MyNotes.DataStorage.DomainObjects.Mappings
{
    using FluentNHibernate.Mapping;
    using MyNotes.DataStorage.DomainObjects.Entities;

    public class TransactionMap : EntityBaseMap<Transaction>
    {
        public TransactionMap()
        {
            Map(x => x.Month)
                .Not.Nullable();
            Map(x => x.Year)
                .Not.Nullable();
            Map(x => x.Balance)
                .Not.Nullable();
            Map(x => x.Incoming)
                .Not.Nullable();
            References(x => x.Account)
                .Not.Nullable();
        }
    }
}
