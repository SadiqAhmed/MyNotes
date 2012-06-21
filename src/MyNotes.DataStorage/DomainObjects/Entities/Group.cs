namespace MyNotes.DataStorage.DomainObjects.Entities
{
    using System;

    public class Group : EntityBase
    {
        /// <summary>
        /// Gets or Sets the group name
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or Sets the list of users in the group
        /// </summary>
        public virtual User Users { get; set; }
    }
}
