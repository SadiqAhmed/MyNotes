namespace MyNotes.Backend.Dtos
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class UserDto
    {
        [DataMember]
        public Guid Id { get; set; }
        
        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Nickname { get; set; }

        [DataMember]
        public string Username { get; set; }
        
        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public Guid GroupId { get; set; }

        [DataMember]
        public string GroupName { get; set; }
    }
}