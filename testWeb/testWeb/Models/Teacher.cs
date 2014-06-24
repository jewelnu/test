using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace testWeb.Models
{
    public class Teacher
    {
        public int TeacherId { set; get; }
        [Required]
        public string Name { set; get; }
        public string Address { set; get; }
        [Required]
       // [RegularExpression(@”[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}”)]
        public string Email { set; get; }
        [Range(11,14)]
        public string Contact { set; get; }
        public int DesignationId { set; get; }
        public virtual Designation Designation { set; get; }
        public int DepartmentId { set; get; }
        public virtual Department Department { set; get; }
        public int CreditToBeTaken { set; get; }
    }
}