using FaceCode.DAO;
using FaceCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FaceCode.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Validate(string email, string password)
        {
            UserDAO userDAO = new UserDAO();
            User user = userDAO.Find(email, password);
            if (user != null)
            {
                Session["UserLogged"] = user;
                return RedirectToAction("Index","UserPage");
            }
            else
            {
                return RedirectToAction("Index","Home");
            }

            
        }

        public ActionResult SignUp()
        {
            return View();
        }

        public ActionResult AddUser(string email,string password)
        {
            UserDAO userDAO = new UserDAO();
            userDAO.Add(new User() { email = email, password = password });

            return RedirectToAction("Index", "Home");
        }
    }
}