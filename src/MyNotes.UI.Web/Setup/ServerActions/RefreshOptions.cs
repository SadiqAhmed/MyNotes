namespace MyNotes.UI.Web.Setup.ServerActions
{
    public class RefreshOptions
    {
        public string ContentViewName { get; set; }

        public object ContentViewModel { get; set; }

        public string PopupViewName { get; set; }

        public object PopupViewModel { get; set; }

        public string ResultViewName { get; set; }

        public object ResultViewModel { get; set; }

        public string RedirectUrl { get; set; }
    }
}