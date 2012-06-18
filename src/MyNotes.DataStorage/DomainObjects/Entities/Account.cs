namespace MyNotes.DataStorage.DomainObjects.Entities
{
    using System;

    public class Account : EntityBase
    {
        /// <summary>
        /// Gets or Sets the currency type
        /// </summary>
        public CurrencyType CurrencyType { get; set; }

        /// <summary>
        /// Gets or Sets the user id
        /// </summary>
        public User UserId { get; set; }
    }
}
