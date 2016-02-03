using Students.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Students.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Rsvp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Rsvp(Student student)
        {
            if (ModelState.IsValid)
            {
                Repository.Add(student);
                return View("Thanks", student);
            }
            else {
                return View();
            }
        }
    }
}