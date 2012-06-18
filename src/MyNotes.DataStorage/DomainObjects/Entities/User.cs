namespace MyNotes.DataStorage.DomainObjects.Entities
{
    using System;

    public class User : EntityBase
    {
        /// <summary>
        /// Gets or Sets the first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets the last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets the nick name
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// Gets or Sets the bool value to use nick name in application
        /// </summary>
        public bool UseNickname { get; set; }

        /// <summary>
        /// Gets or Sets the group id
        /// </summary>
        public Group GroupId { get; set; }
    }
}
