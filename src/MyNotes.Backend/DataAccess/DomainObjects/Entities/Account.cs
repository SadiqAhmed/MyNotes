namespace MyNotes.Backend.DataAccess.DomainObjects.Entities
{
    using System;
    using System.Collections.Generic;

    internal class Account : EntityBase
    {
        public Account()
        {
            User = new User();
            Transactions = new List<Transaction>();
        }

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
        public virtual IList<Transaction> Transactions { get; set; }
    }
}
