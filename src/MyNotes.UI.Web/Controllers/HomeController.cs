namespace MyNotes.UI.Web.Controllers
{
    using System.Web.Mvc;
    using MyNotes.UI.Web.EchoServiceRef;
    using Microsoft.Practices.Unity;

    public class HomeController : Controller
    {
        [Dependency]
        public IEchoService EchoService { get; set; }

        public ActionResult Index()
        {
            ViewBag.Value = EchoService.PrintName("avi");

            return View();
        }
    }
}
