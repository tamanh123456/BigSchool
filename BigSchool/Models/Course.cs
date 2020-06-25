﻿using System;
#pragma warning disable IDE0005 // Using directive is unnecessary.
using System.Collections.Generic;
using System.Linq;
using System.Web;
#pragma warning restore IDE0005 // Using directive is unnecessary.
using System.ComponentModel.DataAnnotations;
namespace BigSchool.Models
{
    public class Course
    {
        public int ID { get; set; }
        public bool IsCanceled { get; set; }
        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string LecturerId { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime DateTime { get; set; }

        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
     
    }
    
}