using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineRealEstateEntity;
using OnlineRealEstateBL;
using System.Web.Mvc;

namespace OnlineRealEstate.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SignUp(UserManager userManager)
        {
            if (ModelState.IsValid)
            {
                int userId = UserBL.SignUp(userManager);
                if (userId > 0)
                {
                    ViewBag.Message = "Register successfull";
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.Message = "Login Successfull";
            return View();
        }
    }
}