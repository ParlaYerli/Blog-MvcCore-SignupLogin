using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blogblog.Data;
using blogblog.Models;
using blogblog.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace blogblog.Controllers
{
    public class UserController : Controller
    {
        private UserContext _context;
        public UserController(UserContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View();
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignUp(SignUser user)
        {
            var newUser = new User
            {
                Username = user.Username,
                Password = user.Password,
                EmailAddress = user.EmailAddress
            };
            if (ModelState.IsValid)
            {
                _context.User.Add(newUser);
                _context.SaveChanges();
                ModelState.Clear();
                ViewBag.Message =newUser.Username + " Adlı Yeni Kullanıcı " +" , " +newUser.EmailAddress + " Mail Adresiyle Başarıyla Kaydedildi !";
                ModelState.Clear();
            }
            

            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(LoginUser model)
        {
            var account = _context.User.Where(u => u.Username == model.Username && u.Password == model.Password).FirstOrDefault();
            if (account != null)
            {
                HttpContext.Session.SetString("UserID", account.UserID.ToString());
                HttpContext.Session.SetString("Username", account.Username);
                return RedirectToAction("Welcome");
            }
            else
            {
                ModelState.AddModelError("", "Username or Password is wrong");
            }
            return View();
        }

        public IActionResult Welcome()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.Username = HttpContext.Session.GetString("Username");
                return View();
            }
            

            else
            {
                return RedirectToAction("LogIn");
            }
            
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("LogIn");
        }
    }
}