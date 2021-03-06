﻿namespace MyNotes.UI.Web.Setup.StartupTasks.Component.MinifyBundles
{
    using MvcBase.WebHelper.StartupTasks;
    using MvcBase.WebHelper.Mvc.Minifications;
    using Microsoft.Web.Optimization;

    public class CssBundles : IIncludeComponent
    {
        public void Setup()
        {
            var mainCssBundle = new Bundle("~/Include/Cache/main.cssbundle.style", typeof(YuiCssMinify));
            mainCssBundle.AddFile("~/Include/Styles/bootstrap/bootstrap.min.css");
            mainCssBundle.AddFile("~/Include/Styles/bootstrap/bootstrap-responsive.min.css");
            mainCssBundle.AddFile("~/Include/Styles/base/core.style.css");
            BundleTable.Bundles.Add(mainCssBundle);
        }
    }
}