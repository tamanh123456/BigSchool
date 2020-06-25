using BigSchool.Models;
using Microsoft.AspNet.Identity;
#pragma warning disable IDE0005 // Using directive is unnecessary.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
#pragma warning restore IDE0005 // Using directive is unnecessary.
using System.Web.Http;

namespace BigSchool.Controllers.Api
{
    public class CoursesController : ApiController
    {
        public ApplicationDbContext _dbContext { get; set; }
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpDelete]
        public IHttpActionResult Cancel(int id)
        {
            var userId = User.Identity.GetUserId();
            var course = _dbContext.Courses.Single(c => c.ID == id && c.LecturerId == userId);


            if (course.IsCanceled)
            {
                return NotFound();
            }

            course.IsCanceled = true;

            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
