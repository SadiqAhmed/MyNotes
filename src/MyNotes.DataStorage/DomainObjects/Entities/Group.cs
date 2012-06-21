namespace MyNotes.DataStorage.DomainObjects.Entities
{
    using System;
    using System.Collections.Generic;

    public class Group : EntityBase
    {
        /// <summary>
        /// Gets or Sets the group name
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or Sets the list of users in the group
        /// </summary>
        public virtual IList<User> Users { get; set; }
    }
}
