namespace MyNotes.UI.Web.Setup.StartupTasks.Component
{
    using MvcBase.WebHelper.StartupTasks;
    using Microsoft.Web.Optimization;
    using MvcBase.WebHelper.MVC.Minifications;

    public class JsBundles : IIncludeComponents
    {
        public void Setup()
        {
            var mainJsBundle = new Bundle("~/Include/Cache/MainJsBundle.Script", typeof(YuiJsMinify));
            mainJsBundle.AddFile("~/Include/Scripts/jQuery/jquery.validate.min.js");
            mainJsBundle.AddFile("~/Include/Scripts/jQuery/jquery.validate.unobtrusive.min.js");
            mainJsBundle.AddFile("~/Include/Scripts/misc/knockout-2.0.0.js");
            mainJsBundle.AddFile("~/Include/Scripts/misc/modernizr-2.5.3.js");
            mainJsBundle.AddFile("~/Include/Scripts/misc/bootstrap.min.js");
            mainJsBundle.AddFile("~/Include/Scripts/base/common.js");
            mainJsBundle.AddFile("~/Include/Scripts/base/core.shared.js");
            mainJsBundle.AddFile("~/Include/Scripts/base/core.ajax.js");
            mainJsBundle.AddFile("~/Include/Scripts/base/core.address.js");
            mainJsBundle.AddFile("~/Include/Scripts/base/core.forms.js");
            BundleTable.Bundles.Add(mainJsBundle);
        }
    }
}