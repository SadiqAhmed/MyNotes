namespace MyNotes.UI.Web.ViewModels.User
{
    using System;

    public class UserViewModel
    {
        public Guid Id { get; set; }

        public string Username { get; set; }

        public string Name { get; set; }

        public string Nickname { get; set; }

        public Guid GroupId { get; set; }

        public string GroupName { get; set; }
    }
}