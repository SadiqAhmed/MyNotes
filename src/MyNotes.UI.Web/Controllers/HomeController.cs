namespace MyNotes.UI.Web.Controllers
{
    using System.Web.Mvc;
    using MyNotes.UI.Web.EchoServiceRef;
    using Microsoft.Practices.Unity;

    public partial class HomeController : Controller
    {
        [Dependency]
        public IEchoService EchoService { get; set; }

        public virtual ActionResult Index()
        {
            ViewBag.Value = EchoService.Ping();

            return View();
        }
    }
}
