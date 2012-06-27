namespace MyNotes.Backend.DataAccess.DomainObjects.Entities
{
    using System;

    public abstract class EntityBase
    {
        /// <summary>
        /// Gets or Sets the Id
        /// </summary>
        public virtual Guid Id { get; protected set; }

        /// <summary>
        /// Gets or Sets the active status
        /// </summary>
        public virtual bool IsActive { get; set; }

        /// <summary>
        /// Gets or Sets the created date time
        /// </summary>
        public virtual DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets the modified date time
        /// </summary>
        public virtual DateTime LastModifiedDate { get; set; }
    }
}
