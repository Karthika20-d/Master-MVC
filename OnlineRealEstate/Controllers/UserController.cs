﻿using System.Collections.Generic;
using OnlineRealEstateEntity;
using OnlineRealEstateRepositary;
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
            IEnumerable<Land> land = LandRepositary.GetLandDetails();
            ViewBag.Land = land;
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