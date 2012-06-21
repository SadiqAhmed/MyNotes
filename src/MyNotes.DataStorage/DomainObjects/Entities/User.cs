namespace MyNotes.DataStorage.DomainObjects.Entities
{
    using System;
    using System.Collections.Generic;

    public class User : EntityBase
    {
        /// <summary>
        /// Gets or Sets the first name
        /// </summary>
        public virtual string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets the last name
        /// </summary>
        public virtual string LastName { get; set; }

        /// <summary>
        /// Gets or Sets the nick name
        /// </summary>
        public virtual string Nickname { get; set; }

        /// <summary>
        /// Gets or Sets the bool value to use nick name in application
        /// </summary>
        public virtual bool UseNickname { get; set; }

        /// <summary>
        /// Gets or Sets the user group
        /// </summary>
        public virtual Group Group { get; protected set; }

        /// <summary>
        /// Gets or Sets the list of accounts with the user
        /// </summary>
        public virtual IList<Account> Accounts { get; set; }
    }
}
