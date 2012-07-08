namespace MyNotes.UI.Web.Setup.StartupTasks.Component.MinifyBundles
{
    using MvcBase.WebHelper.StartupTasks;
    using Microsoft.Web.Optimization;
    using MvcBase.WebHelper.MVC.Minifications;

    public class JsBundles : IIncludeComponent
    {
        public void Setup()
        {
            var mainJsBundle = new Bundle("~/Include/Cache/main.jsbundle.script", typeof(YuiJsMinify));
            mainJsBundle.AddFile("~/Include/Scripts/jQuery/jquery.metadata.js");
            mainJsBundle.AddFile("~/Include/Scripts/jQuery/jquery.blockUI.js");
            mainJsBundle.AddFile("~/Include/Scripts/jQuery/jquery.ba-bbq.min.js");
            mainJsBundle.AddFile("~/Include/Scripts/jQuery/jquery.validate.min.js");
            mainJsBundle.AddFile("~/Include/Scripts/jQuery/jquery.validate.unobtrusive.min.js");
            mainJsBundle.AddFile("~/Include/Scripts/jQuery/chosen.jquery.js");
            mainJsBundle.AddFile("~/Include/Scripts/misc/knockout-2.0.0.js");
            mainJsBundle.AddFile("~/Include/Scripts/misc/modernizr-2.5.3.js");
            mainJsBundle.AddFile("~/Include/Scripts/misc/bootstrap.min.js");
            mainJsBundle.AddFile("~/Include/Scripts/base/core.shared.js");
            mainJsBundle.AddFile("~/Include/Scripts/base/core.handler.js");
            mainJsBundle.AddFile("~/Include/Scripts/base/core.ajax.js");
            mainJsBundle.AddFile("~/Include/Scripts/base/core.address.js");
            mainJsBundle.AddFile("~/Include/Scripts/base/core.forms.js");
            mainJsBundle.AddFile("~/Include/Scripts/base/app.common.js");
            BundleTable.Bundles.Add(mainJsBundle);

            var loginBundle = new Bundle("~/Include/Cache/login.script", typeof(YuiJsMinify));
            mainJsBundle.AddFile("~/Include/Scripts/app/login.js");
            BundleTable.Bundles.Add(mainJsBundle);
        }
    }
}