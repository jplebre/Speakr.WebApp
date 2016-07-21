using Microsoft.AspNetCore.Mvc;
using Speakr.WebApp.Site.Infrastructure.Database;
using Speakr.WebApp.Site.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Speakr.WebApp.Site.Controllers
{
    [Route("Users")]
    public class UserRegistrationController : Controller
    {
        private IUserService _userService;

        public UserRegistrationController(IUserService userService)
        {
            _userService = userService;
            
        }
        [Route("AddUser")]
        public IActionResult AddUser(string first, string last)
        {
            var user = new UserDetails() { FirstName = first, LastName = last };
            _userService.AddUser(user);
            return Content($"{first} {last}");
        }

        [Route("GetUser")]
        public IActionResult GetUser(int id)
        {
            var user = _userService.GetUserById(id);
            return Json(user);
        }
    }
}
