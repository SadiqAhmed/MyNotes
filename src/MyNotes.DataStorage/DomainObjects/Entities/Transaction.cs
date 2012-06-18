namespace MyNotes.DataStorage.DomainObjects.Entities
{
    using System;

    public class Transaction : EntityBase
    {
        /// <summary>
        /// Gets or Sets the year of transaction
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Gets or Sets the month of transaction
        /// </summary>
        public int Month { get; set; }

        /// <summary>
        /// Gets or Sets the balance amount before transaction
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// Gets or Sets the incoming amount
        /// </summary>
        public decimal Incoming { get; set; }

        /// <summary>
        /// Gets or Sets the account id
        /// </summary>
        public Account AccountId { get; set; }
    }
}
