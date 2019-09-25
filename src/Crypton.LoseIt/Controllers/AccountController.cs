using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Crypton.LoseIt.Controllers
{
    [Route("account")]
    [AllowAnonymous]
    public class AccountController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("register")]
        public IActionResult Register()
        {
            return View();
        }

        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}