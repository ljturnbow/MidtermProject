using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MidtermProject.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult Index()
        {
            return View();
        }

        // Creating/Adding the Courses
        public ActionResult CreateCourse()
        {
            return View();
        }

        // Edit the Courses
        public ActionResult EditCourse()
        {
            return View();
        }

        // Delete Course
        public ActionResult DeleteCourse()
        {
            return View();
        }

        // Update Course
        public ActionResult UpdateCourse()
        {
            return View();
        }
    }
}