using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDataAnnotation.Models;

namespace MVCDataAnnotation.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public JsonResult IsValidDate(DateTime DOB)
        {
            bool Status;
            if (DOB > DateTime.Now.AddYears(-18))
            {
                Status = false;
            }
            else
            {
                Status = true;
            }
            return Json(Status,JsonRequestBehavior.AllowGet);
        }
        public ViewResult AddUser()
        {
            return View();
        }
        public ViewResult DisplayUser(User user)
        {
            if (ModelState.IsValid)
            {
                return View(user);
            }
            else
            {
                return View("AddUser", user);
            }
            
        }
    }
}