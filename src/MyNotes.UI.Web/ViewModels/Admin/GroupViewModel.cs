namespace MyNotes.UI.Web.ViewModels.Admin
{
    using System;

    public class GroupViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsSystem { get; set; }
    }
}