namespace MyNotes.DataStorage.DomainObjects.Entities
{
    using System;

    public abstract class EntityBase
    {
        /// <summary>
        /// Gets or Sets the Id
        /// </summary>
        public Guid Id { get; internal set; }
    }
}
