namespace MyNotes.UI.Web.Controllers
{
    using System.Web.Mvc;

    public partial class AdminController : Controller
    {
        public virtual ActionResult Index()
        {
            return View();
        }
    }
}
