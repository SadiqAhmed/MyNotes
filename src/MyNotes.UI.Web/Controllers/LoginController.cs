namespace MyNotes.UI.Web.Controllers
{
    using System.Web.Mvc;
    using MyNotes.UI.Web.ViewModels.Login;
    using MyNotes.UI.Web.UserServiceRef;
    using MvcBase.WebHelper.MVC.Attributes;
    using AutoMapper;

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
        public virtual ActionResult ValidateCredentials(UserLoginViewModel viewmodel)
        {
            var userInfoDto = _userService.Authenticate(viewmodel.Username, viewmodel.Password);
            var userViewModel = Mapper.Map<UserDetailViewModel>(userInfoDto);
            return View(MVC.Login.Views.LoginSuccess, userViewModel);
        }
    }
}
