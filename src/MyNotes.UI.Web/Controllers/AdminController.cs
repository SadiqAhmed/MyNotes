namespace MyNotes.UI.Web.Controllers
{
    using System.Web.Mvc;
    using MyNotes.UI.Web.AdminServiceRef;
    using MyNotes.UI.Web.Setup.ActionApi;
    using MyNotes.UI.Web.Setup.Common;
    using MyNotes.UI.Web.ViewModels.Admin;
    using System.Collections.Generic;
    using AutoMapper;
    using MyNotes.UI.Web.Setup.Extensions;
    using MyNotes.UI.Web.ViewModels.User;
    using MyNotes.UI.Web.UserServiceRef;

    public partial class AdminController : Controller
    {
        IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
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
                                    var groups = _adminService.GetAllGroups();
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
                                    var users = _adminService.GetAllUsers(loggedInUser.GroupId);
                                    return Mapper.Map<IList<UserViewModel>>(users);
                                })
                        .Execute();
        }

        [HttpGet]
        public virtual ActionResult AddNewGroup()
        {
            return new ServiceAction(this)
                        .Fetch(SessionKey.Empty)
                        .WithPopup<GroupViewModel>(MVC.Admin.Views._addGroup,
                                () =>
                                {
                                    return new GroupViewModel();
                                })
                        .Execute();
        }

        [HttpPost]
        public virtual ActionResult SaveGroup(GroupViewModel groupViewModel)
        {
            return new ServiceAction(this)
                        .Put(SessionKey.Empty)
                        .WithCommand<bool>(() =>
                            {
                                return _adminService.AddGroup(groupViewModel.Name);
                            })
                        //.OnSuccess(MVC.Admin.Actions.Groups())
                        //.OnFailure(MVC.Admin.Actions.Groups())
                        .Execute();
        }
    }
}
