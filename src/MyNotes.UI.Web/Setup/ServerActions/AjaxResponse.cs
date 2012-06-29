namespace MyNotes.UI.Web.Setup.ServerActions
{
    public class AjaxResponse
    {
        public AjaxResponse()
        {
            Message = null;
            DataCaptureView = null;
            DataCaptureIsWizard = false;
            ContentView = null;
            ContentIsWizard = false;
            RedirectUrl = null;
            ResultIsWizard = false;
            Result = null;
        }

        public bool HasError { get; set; }

        public string Message { get; set; }

        public string DataCaptureView { get; set; }

        public bool DataCaptureIsWizard { get; set; }

        public string ContentView { get; set; }

        public bool ContentIsWizard { get; set; }

        public string Result { get; set; }

        public bool ResultIsWizard { get; set; }

        public string RedirectUrl { get; set; }
    }
}