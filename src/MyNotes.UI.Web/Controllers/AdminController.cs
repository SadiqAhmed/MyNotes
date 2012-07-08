namespace MyNotes.UI.Web.Controllers
{
    using System.Web.Mvc;
    using MyNotes.UI.Web.UserServiceRef;
    using MyNotes.UI.Web.Setup.ActionApi;
    using MyNotes.UI.Web.Setup.Common;
    using MyNotes.UI.Web.ViewModels.Admin;
    using System.Collections.Generic;
    using AutoMapper;
    using MyNotes.UI.Web.Setup.Extensions;
    using MyNotes.UI.Web.ViewModels.User;

    public partial class AdminController : Controller
    {
        IUserService _userService;

        public AdminController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public virtual ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public virtual ActionResult Groups()
        {
            return new ServiceAction(this)
                        .Fetch(SessionKey.Empty)
                        .WithContent<IList<GroupViewModel>>(MVC.Admin.Views._groups,
                                () =>
                                {
                                    var groups = _userService.GetAllGroups();
                                    return Mapper.Map<IList<GroupViewModel>>(groups);
                                })
                        .Execute();
        }

        [HttpGet]
        public virtual ActionResult Users()
        {
            return new ServiceAction(this)
                        .Fetch(SessionKey.Empty)
                        .WithContent<IList<UserViewModel>>(MVC.Admin.Views._users,
                                () =>
                                {
                                    var loggedInUser = Session.GetValue<LoggedUserInfoDto>(SessionKey.Loggeduser);
                                    var users = _userService.GetAllUsers(loggedInUser.GroupId);
                                    return Mapper.Map<IList<UserViewModel>>(users);
                                })
                        .Execute();
        }
    }
}
