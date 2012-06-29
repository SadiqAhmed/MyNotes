namespace MyNotes.Backend.DataAccess.DomainObjects.Entities
{
    using System;
    using System.Collections.Generic;

    internal class User : EntityBase
    {
        protected string _nickname;

        public User()
        {
            Group = new Group();
            Accounts = new List<Account>();
        }

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
        public virtual string Nickname
        {
            get { return string.IsNullOrEmpty(_nickname) ? FirstName : _nickname; }
            set { _nickname = value; }
        }

        /// <summary>
        /// Gets or Sets the user name
        /// </summary>
        public virtual string Username { get; set; }

        /// <summary>
        /// Gets or Sets the password
        /// </summary>
        public virtual string Password { get; set; }

        /// <summary>
        /// Gets or Sets the user group
        /// </summary>
        public virtual Group Group { get; set; }

        /// <summary>
        /// Gets or Sets the list of accounts with the user
        /// </summary>
        public virtual IList<Account> Accounts { get; set; }
    }
}
