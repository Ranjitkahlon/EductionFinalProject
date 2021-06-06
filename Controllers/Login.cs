using EductionFinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EductionFinalProject.Controllers
{
    public class Login : Controller
    {

        public IActionResult login()
        {
            return View();
        }

      


        public IActionResult Invalid()
        {
            return View();
        }

        public IActionResult dashboard()
        {
            return View();
        }

        public ActionResult sign_In(userLogin lg)
        {
            if (lg.userNme.Equals("admin@gmail.com") && lg.userPssword.Equals("123456"))
            {
                return View("dashboard");
            }
            else {
                return View("Invalid");
            }
            
        }

    }
}
