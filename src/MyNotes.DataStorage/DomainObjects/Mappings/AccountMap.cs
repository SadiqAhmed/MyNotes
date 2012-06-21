﻿namespace MyNotes.DataStorage.DomainObjects.Mappings
{
    using FluentNHibernate.Mapping;
    using MyNotes.DataStorage.DomainObjects.Entities;

    public class AccountMap : EntityBaseMap<Account>
    {
        public AccountMap()
        {
            Map(x => x.CurrencyType)
                .Not.Nullable();
            References(x => x.User);
        }
    }
}