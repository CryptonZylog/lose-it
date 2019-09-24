using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Crypton.LoseIt.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        [Route("")]
        public IActionResult Index()
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