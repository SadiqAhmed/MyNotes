namespace MyNotes.DataStorage.DomainObjects.Entities
{
    using System;

    public class Account : EntityBase
    {
        /// <summary>
        /// Gets or Sets the currency type
        /// </summary>
        public virtual CurrencyType CurrencyType { get; set; }

        /// <summary>
        /// Gets or Sets the user of the account
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Gets or Sets the list of transactions in this account
        /// </summary>
        public virtual Transaction Transactions { get; set; }
    }
}
