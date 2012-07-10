namespace MyNotes.Backend.Dtos
{
    using System.Runtime.Serialization;

    [DataContract]
    public class MessageResultDto
    {
        [DataMember]
        public bool HasError { get; set; }

        [DataMember]
        public string Message { get; set; }

        public void ErrorMessage(string message)
        {
            HasError = true;
            Message = message;
        }
    }
}