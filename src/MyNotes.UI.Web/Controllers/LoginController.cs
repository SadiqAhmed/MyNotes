namespace MyNotes.UI.Web.Controllers
{
    using System.Web.Mvc;
    using MyNotes.UI.Web.ViewModels.Login;
    using MyNotes.UI.Web.UserServiceRef;
    using MvcBase.WebHelper.MVC.Attributes;
    using AutoMapper;
    using MyNotes.UI.Web.Setup;
    using MyNotes.UI.Web.Setup.ActionApi;
    using Microsoft.Practices.Unity;
    using MyNotes.UI.Web.Setup.Common;

    public partial class LoginController : Controller
    {
        IServiceAction _serviceAction;
        IUserService _userService;

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        public virtual ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public virtual ActionResult ValidateCredentials(UserLoginViewModel viewmodel)
        {
            return new ServiceAction(this)
                        .Fetch(SessionKey.Home)
                        .WithPopup<UserDetailViewModel>(MVC.Login.Views.LoginSuccess,
                            () => {
                                var userDetail = _userService.Authenticate(viewmodel.Username, viewmodel.Password);
                                return Mapper.Map<UserDetailViewModel>(userDetail);
                            })
                        .Execute();
        }
    }
}
