namespace MyNotes.UI.Web.Controllers
{
    using System.Web.Mvc;
    using MyNotes.UI.Web.ViewModels.Login;
    using MyNotes.UI.Web.UserServiceRef;
    using MvcBase.WebHelper.MVC.Attributes;

    public partial class LoginController : Controller
    {
        IUserService _userService;

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        public virtual ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [JsonFilter]
        public virtual ActionResult ValidateCredentials(UserLoginViewModel viewmodel)
        {
            var userInfo = _userService.Authenticate(viewmodel.Username, viewmodel.Password);
            return Json(userInfo);
        }
    }
}
