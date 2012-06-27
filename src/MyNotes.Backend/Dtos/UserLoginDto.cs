namespace MyNotes.Backend.Dtos
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class UserLoginDto
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Nickname { get; set; }

        [DataMember]
        public string GroupName { get; set; }
    }
}