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
            var userDeatils = db.Users.Where(x => x.Email == user.Email && x.password == user.password && x.userRole == user.userRole).FirstOrDefault();
            if (userDeatils == null)
            {
                user.LoginErrorMessge = "wrong Email or Password.";
                return View("Login", user);
            }
            else
            {
                Session["UserId"] = userDeatils.userId;
                Session["userName"] = userDeatils.name;
                return RedirectToAction("Index", "Users");
            }
        }
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(User user)
        {

            var userDeatils = db.Users.Where(x => x.Email == user.Email && x.password == user.password).FirstOrDefault();
            if (userDeatils == null)
            {
                user.LoginErrorMessge = "wrong Email or Password.";
                return View("Login", user);
            }
            else
            {
                Session["UserId"] = userDeatils.userId;
                Session["userName"] = userDeatils.name;
                return RedirectToAction("Index", "Admin");
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
        public ActionResult Register([Bind(Include = "userId,Email,name,password,mobileNumber,userRole")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(user);
        }
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration([Bind(Include = "userId,Email,name,password,mobileNumber,userRole")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}