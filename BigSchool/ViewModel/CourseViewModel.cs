using BigSchool.Models;
using System;
using System.Collections.Generic;
#pragma warning disable IDE0005 // Using directive is unnecessary.
using System.Linq;
using System.Web;
#pragma warning restore IDE0005 // Using directive is unnecessary.
using System.ComponentModel.DataAnnotations;

namespace BigSchool.ViewModel

{
    public class CourseViewModel

    {
        public int Id { get; set; }
        //public IEnumerator<Course> UpcomingCourses { get; set; }
        //public IEnumerable<Course> UpcomingCourses { get; set; }
        //public bool ShowAction { get; set; }

        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1} ", Date, Time));
        }
        public string Heading { get; set; }
        public string Action
        {
            get { return (Id != 0) ? "Update" : "Create"; }
        }
    }
}