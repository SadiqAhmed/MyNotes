namespace MyNotes.UI.Web.Setup.ActionApi
{
    public class AjaxResponse
    {
        public AjaxResponse()
        {
            Message = null;
            PopupView = null;
            ContentView = null;
            ContentIsWizard = false;
            RedirectUrl = null;
            Result = null;
        }

        public bool HasError { get; set; }

        public string Message { get; set; }

        public string PopupView { get; set; }

        public string ContentView { get; set; }

        public bool ContentIsWizard { get; set; }

        public object Result { get; set; }

        public string RedirectUrl { get; set; }
    }
}