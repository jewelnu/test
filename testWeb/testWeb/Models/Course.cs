using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testWeb.Models
{
    public class Course
    {
        public int CourseId { set; get; }
        [Required]
       // [Remote("CheckCode", "Course", ErrorMessage = "Already Exist")]
        public string Code { set; get; }
        public int Credit { set; get; }
        [Required]
       // [Remote("CheckName", "Course", ErrorMessage = "Already Exist")]
        public string Name { set; get; }
        public string Description { set; get; }
        public int DepartmentId { set; get; }
        public virtual Department Department { set; get; }
        public int SemesterId { set; get; }
        public virtual Semester Semester { set; get; }
    }
}