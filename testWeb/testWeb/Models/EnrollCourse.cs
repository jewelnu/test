using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testWeb.Models
{
    public class EnrollCourse
    {
        public int StudentId { set; get; }
        public virtual Student Student { set; get; }
        public int CourseId { set; get; }
        public virtual Course Course { set; get; }
        public DateTime EnrollDate { set; get; }
       
    }
}