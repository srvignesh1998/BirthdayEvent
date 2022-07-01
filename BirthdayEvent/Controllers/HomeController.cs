using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BirthdayEvent.Models;

namespace BirthdayEvent.Controllers
{
    public class HomeController : Controller
    {
        private DBContextClass db = new DBContextClass();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {

            var userDeatils = db.Users.Where(x => x.Email == user.Email && x.password == user.password).FirstOrDefault();
            if (userDeatils == null)
            {
                TempData["LoginAlertMessage"] = "Wrong Email or Password...";
                return View("Login", user);
            }
            else
            {
                Session["UserId"] = userDeatils.userId;
                Session["userName"] = userDeatils.name;
                if (userDeatils.userRole == "admin")
                {
                    return RedirectToAction("Index", "Admin");
                }
                else if(userDeatils.userRole == "user")
                {
                    return RedirectToAction("Index", "Users");
                }
                else
                {
                    return RedirectToAction("Login", "Home");
                }
            }
        }
        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Login", "Home");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "userId,Email,name,password,ConfirmPassword,mobileNumber,userRole")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                TempData["RegisterAlertMessage"]="Registered Successfully...!";
            }
            return View(user);
        }

    }
}