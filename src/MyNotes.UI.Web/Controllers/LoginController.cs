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
    using MyNotes.UI.Web.Setup.Extensions;

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

        [HttpGet]
        public virtual ActionResult ValidateCredentials(UserLoginViewModel viewmodel)
        {
            return new ServiceAction(this)
                        .Fetch(SessionKey.Login)
                        .WithResult<UserLoginDto>(() => {
                                var userDetail = _userService.Authenticate(viewmodel.Username, viewmodel.Password);
                                Session.SetValue(SessionKey.UserDetails, userDetail);
                                return userDetail;
                            })
                        .Execute();
        }
    }
}
