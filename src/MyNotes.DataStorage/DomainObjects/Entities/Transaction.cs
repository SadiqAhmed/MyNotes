namespace MyNotes.DataStorage.DomainObjects.Entities
{
    using System;

    public class Transaction : EntityBase
    {
        /// <summary>
        /// Gets or Sets the year of transaction
        /// </summary>
        public virtual int Year { get; set; }

        /// <summary>
        /// Gets or Sets the month of transaction
        /// </summary>
        public virtual int Month { get; set; }

        /// <summary>
        /// Gets or Sets the balance amount before transaction
        /// </summary>
        public virtual decimal Balance { get; set; }

        /// <summary>
        /// Gets or Sets the incoming amount
        /// </summary>
        public virtual decimal Incoming { get; set; }

        /// <summary>
        /// Gets or Sets the transaction account
        /// </summary>
        public virtual Account Account { get; set; }
    }
}
