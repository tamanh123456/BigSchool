using BigSchool.Models;
using System;
#pragma warning disable IDE0005 // Using directive is unnecessary.
using System.Collections.Generic;
#pragma warning restore IDE0005 // Using directive is unnecessary.
using System.Linq;
#pragma warning disable IDE0005 // Using directive is unnecessary.
using System.Web;
#pragma warning restore IDE0005 // Using directive is unnecessary.
using System.Web.Mvc;
using System.Data.Entity;
using BigSchool.ViewModel;

namespace BigSchool.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;
        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var upComingCourses = _dbContext.Courses.Include(c => c.Lecturer).Include(c => c.Category).Where(c => c.DateTime > DateTime.Now);
            var viewModel = new CoursesViewModel
            {
                UpcommingCourses = upComingCourses,
                ShowAction=User.Identity.IsAuthenticated
            };
            return View(viewModel);
           
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