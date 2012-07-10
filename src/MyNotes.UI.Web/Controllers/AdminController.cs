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
    using System.Linq;

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
                                    var loggedInUser = Session.GetValue<LoggedUserInfoDto>(SessionKey.LoggedUser);
                                    var users = _adminService.GetAllUsers(loggedInUser.GroupId, loggedInUser.IsSysAccount);
                                    return Mapper.Map<IList<UserViewModel>>(users);
                                })
                        .Execute();
        }

        [HttpGet]
        public virtual ActionResult AddGroup()
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
                        .WithCommand<MessageResultDto>(() =>
                            {
                                return _adminService.AddGroup(groupViewModel.Name);
                            })
                        .Execute();
        }

        [HttpGet]
        public virtual ActionResult AddUser()
        {
            return new ServiceAction(this)
                        .Fetch(SessionKey.Empty)
                        .WithPopup<UserViewModel>(MVC.Admin.Views._addUser,
                                () =>
                                {
                                    var groups = (from gp in _adminService.GetAllGroups()
                                                  select new SelectListItem { Value = gp.Id.ToString(), Text = gp.Name }).ToList();
                                    ViewData["Groups"] = groups;
                                    return new UserViewModel();
                                })
                        .Execute();
        }

        [HttpPost]
        public virtual ActionResult SaveUser(UserViewModel userViewModel)
        {
            return new ServiceAction(this)
                        .Put(SessionKey.Empty)
                        .WithCommand<MessageResultDto>(() =>
                        {
                            return _adminService.AddUser(userViewModel.Firstname, userViewModel.Lastname, userViewModel.Nickname, userViewModel.Username, userViewModel.Password, userViewModel.GroupId);
                        })
                        .Execute();
        }
    }
}
