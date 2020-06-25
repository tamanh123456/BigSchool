#pragma warning disable IDE0005 // Using directive is unnecessary.
using System;
#pragma warning restore IDE0005 // Using directive is unnecessary.
using System.Collections.Generic;
#pragma warning disable IDE0005 // Using directive is unnecessary.
using System.Linq;
using System.Web;
#pragma warning restore IDE0005 // Using directive is unnecessary.
using BigSchool.Models;

namespace BigSchool.ViewModel
{
    public class FollowingViewModel
    {
        public IEnumerable<ApplicationUser> Followings { get; set; }
        public bool ShowAction { get; set; }
    }
}